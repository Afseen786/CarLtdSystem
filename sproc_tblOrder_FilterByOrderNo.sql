CREATE PROCEDURE sproc_tblOrder_FilterByOrderNo
--parameter to store the order no we are looking for
	@OrderNo int

AS
--selct all fields from the table where the order no matches the parameter data
	SELECT * FROM tblOrder WHERE OrderNo = @OrderNo

RETURN 0