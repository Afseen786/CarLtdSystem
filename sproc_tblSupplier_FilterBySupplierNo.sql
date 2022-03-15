CREATE PROCEDURE sproc_tblSupplier_FilterBySupplierNo
--parameter to store the supplier 
@SupplierNo int

AS

select * from tblSupplier where SupplierId = @SupplierId

RETURN 0 