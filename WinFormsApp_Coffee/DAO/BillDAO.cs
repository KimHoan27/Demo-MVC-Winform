using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsApp_Coffee.DTO;

namespace WinFormsApp_Coffee.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }

        /// <summary>
        /// Thành công: bill ID
        /// thất bại: -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = clsDB.Instance.execQuery("SELECT * FROM dbo.HOADON WHERE maban = " + id + " AND trangthaihoadon = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.MaHD;
            }
            return -1;
        }
        public void CheckOut(int id)
        {
            string query = "UPDATE dbo.HOADON SET trangthaihoadon = 1 WHERE mahoadon = " + id;
            clsDB.Instance.execNonQuery(query);
        }
        /*
         create PROC [dbo].[USP_InsertBill]
        @matk int,
        @maban int
        as
        begin 
        insert dbo.HOADON
        (
        mataikhoan,
        giolap,
        maban,
        trangthaihoadon
        )
        values(
        @matk,
        GETDATE(),
        @maban,
        0
        )
        end
         */
        public void InsertBill(int mataikhoan,int idban)
        {
            clsDB.Instance.execQuery("exec USP_InsertBill @matk , @maban", new object[] { mataikhoan , idban });
        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)clsDB.Instance.execScalar("SELECT MAX(mahoadon) FROM dbo.HOADON");
            }
            catch
            {
                return 1;
            }
        }
        /*
         create trigger UTP_UpdateBillInfo
        on dbo.CHITIETHOADON for insert, update
        as
        begin
        declare @idBill int
        select @idBill = mahoadon FROM inserted
        declare @idTable int
        select @idTable = maban from dbo.HOADON where mahoadon = @idBill and trangthaihoadon = 0
        update dbo.BAN set trangthaiban = 1 where maban =@idTable
        end
        go
         */
        /*
         create trigger UTG_UpdateBill
        on dbo.HOADON for update
        as
        begin 
        declare @idBill int
        select @idBill = mahoadon from inserted
        declare @idTable int
        select @idTable = maban from dbo.HOADON where mahoadon = @idBill
        declare @count int =0
        select @count = COUNT(*) from dbo.HOADON where maban = @idTable and trangthaihoadon =0
        if(@count = 0)
        update dbo.BAN set trangthaiban = 0 where maban = @idTable
        end 
        go
         */
        /*
        alter PROCEDURE usp_SwitchTable
           @id1 int, @id2 int
           AS
           BEGIN
               DECLARE @idBill1 int
               DECLARE @idBill2 int
               Declare @isxistBill1 int 
               Declare @isxistBill2 int 

               SELECT @idBill1 = mahoadon FROM dbo.HOADON WHERE maban = @id1 AND trangthaihoadon = 0
               SELECT @idBill2 = mahoadon FROM dbo.HOADON WHERE maban = @id2 AND trangthaihoadon = 0

               SELECT @isxistBill1 = COUNT(*) FROM dbo.CHITIETHOADON as a, dbo.HOADON as b WHERE a.mahoadon = @idBill1 and b.trangthaihoadon=0
               SELECT @isxistBill2 = COUNT(*) FROM dbo.CHITIETHOADON as a, dbo.HOADON as b WHERE a.mahoadon = @idBill2 and b.trangthaihoadon=0



               if(@isxistBill1>0 and @isxistBill2>0)
               begin
               UPDATE dbo.HOADON SET maban = @id2 WHERE mahoadon = @idBill1
               UPDATE dbo.HOADON SET maban = @id1 WHERE mahoadon = @idBill2
               update dbo.BAN set trangthaiban = 1 where maban = @id1
               update dbo.BAN set trangthaiban = 1 where maban = @id2
               end
               else
               begin
               UPDATE dbo.HOADON SET maban = @id2 WHERE mahoadon = @idBill1
               UPDATE dbo.HOADON SET maban = @id1 WHERE mahoadon = @idBill2
               update dbo.BAN set trangthaiban = 0 where maban = @id1
               update dbo.BAN set trangthaiban = 1 where maban = @id2
               end
           END
           GO
        */
    }
}
