using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsApp_Coffee.DTO;

namespace WinFormsApp_Coffee.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }
        private BillInfoDAO() { }

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = clsDB.Instance.execQuery("SELECT * FROM dbo.CHITIETHOADON WHERE mahoadon = " + id);

            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }
        /*
         create proc USP_InsertBillInfo
     @mahd int, @madu int, @sl int
        as
        begin 
        declare @isExistBillInfo int
        declare @foodCount int =1
        declare @price float
        declare @tlgiamgia float
        declare @ngay date = GETDATE()
        select @price = giaban from dbo.SP_DG as b , dbo.GIATHEODOT as a where  b.madouong=@madu and b.madotgia = a.madotgia and @ngay>=a.ngaybdban and a.trangthaigia = 1 
        select @tlgiamgia = tilegiamgia from dbo.CHITIETKHUYENMAI as a, dbo.DOTKHUYENMAI as b where a.madouong = @madu and a.madotkm = b.madotkm and @ngay>=b.ngaybatdau and @ngay<=b.ngayketthuc and b.trangthaidotkm = 1
        select @isExistBillInfo = mahoadon,@foodCount=b.soluong
        from dbo.CHITIETHOADON as b
        where mahoadon = @mahd and madouong = @madu
        if(@isExistBillInfo >0)
        begin
        declare @newcount int = @foodCount + @sl
        if(@newcount>0)
        begin
        if(@price>0)
        begin
        if(@tlgiamgia>0)
        update dbo.CHITIETHOADON set soluong = @foodCount +@sl, tongtien = (@newcount*@price)-(((@newcount*@price)/100)*@tlgiamgia) where madouong = @madu and mahoadon = @mahd
        else
        update dbo.CHITIETHOADON set soluong = @foodCount +@sl, tongtien = @newcount*@price where madouong = @madu and mahoadon = @mahd
        end
        end
        end
        else
        begin
        if(@price >0)
        begin
        if(@tlgiamgia>0)
        insert dbo.CHITIETHOADON
        (mahoadon,madouong,soluong,giatien,tlgiamgia,tongtien)
        values(@mahd, @madu, @sl,@price,@tlgiamgia,(@sl*@price)-(((@sl*@price)/100)*@tlgiamgia)) 
        else        
        insert dbo.CHITIETHOADON
        (mahoadon,madouong,soluong,giatien,tlgiamgia,tongtien)
        values(@mahd, @madu, @sl,@price,0,@sl*@price) 
        end
        end
        end
         */
        public void InsertBillInfo(int mahoadon, int madouong, int sl)
        {
            clsDB.Instance.execQuery("exec USP_InsertBillInfo @mahd , @madu , @sl ", new object[] { mahoadon , madouong , sl });
        }
        /*
         create proc USP_DeleteFood
    @mahd int, @madu int, @sl int
        as
        begin 
        declare @isExistBillInfo int
        declare @foodCount int =1
        declare @price float
        declare @tlgiamgia float
        declare @ngay date = GETDATE()
        select @price = giaban from dbo.SP_DG as b , dbo.GIATHEODOT as a where  b.madouong=@madu and b.madotgia = a.madotgia and @ngay>=a.ngaybdban and a.trangthaigia = 1  
        select @tlgiamgia = tilegiamgia from dbo.CHITIETKHUYENMAI as a, dbo.DOTKHUYENMAI as b where a.madouong = @madu and a.madotkm = b.madotkm and @ngay>=b.ngaybatdau and @ngay<=b.ngayketthuc and b.trangthaidotkm = 1
        select @isExistBillInfo = mahoadon,@foodCount=b.soluong
        from dbo.CHITIETHOADON as b
        where mahoadon = @mahd and madouong = @madu
        if(@isExistBillInfo >0)
        begin
        declare @newcount int = @foodCount - @sl
        if(@newcount>0)
        begin
        if (@tlgiamgia>0)
        update dbo.CHITIETHOADON set soluong = @foodCount - @sl, tongtien = (@newcount*@price)-(((@newcount*@price)/100)*@tlgiamgia) where madouong = @madu and mahoadon =@mahd
        else
        update dbo.CHITIETHOADON set soluong = @foodCount - @sl, tongtien = @newcount * @price where madouong = @madu and mahoadon =@mahd
        end
        else
        delete dbo.CHITIETHOADON where mahoadon = @mahd and madouong = @madu
        end
        end


        go
         */
        public void DeleteBillInfo(int mahoadon, int madouong, int sl)
        {
            clsDB.Instance.execQuery("exec USP_DeleteFood @mahd , @madu , @sl", new object[] { mahoadon, madouong, sl });
        }
    }
}
