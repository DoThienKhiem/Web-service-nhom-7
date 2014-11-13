		1.	Giới thiệu:
Website MVCMobile chuyên bán các sản phẩm điện thoại di động. Mỗi sản phẩm bao gồm các thông tin như: Mã sản phẩm, tên sản phẩm, mô tả, giá, số lượng, hình ảnh, mã danh mục, trạng thái. Mỗi sản phẩm thì thuộc một danh mục, và mỗi danh mục có nhiều sản phẩm khác nhau. Mỗi danh mục chứa các thông tin như: mã danh, tên danh mục. Khách hàng đến với website có thể xem thông tin chi tiết sản phẩm, giá của sản phẩm. Để mua hàng thì khách hàng phải đăng ký một tài khoản trên website. Mỗi tài khoản thì chứa những thông tin như: mã tài khoản, mật khẩu, họ tên, địa chỉ, số điện thoại, ngày sinh, email, trạng thái.
Sau khi đăng ký thì khách hàng có thể đăng nhập và mua hàng thông qua các chức năng của website. Để mua sản phẩm người dùng click vào nút “mua hàng” bên dưới sản phẩm, sau đó khách hàng điền các thông tin cần thiết để đặt hàng.Cuối cùng khách hàng bấm vào nút “hoàn tất” để hoàn tất quá trình mua hàng. Khách hàng có thể thêm vào giỏ hàng, xóa sản phẩm trong giỏ hàng hoặc cập nhật số lượng sản phẩm trong giỏ hàng.
	-Chức năng quản lý dành cho admin:
+ Quản lý sản phẩm: admin có thể xem, thêm , xóa, sửa sản phẩm.
+ Quản lý người dùng: admin có thể xem, xóa, sửa thông tin người dùng.
+ Quản lý trạng thái đơn hàng: admin có thể thay đổi trạng thái của đơn hàng.(mặc định là 1 tức chưa giao hàng)
+ Quản lý tồn kho: Mỗi sản phẩm khi nhập vào kho thì các thông tin như: mã sản phẩm, tên sản phầm, số lượng nhập. Số lượng tồn kho của sản phẩm bất kỳ  là tổng của số lượng còn lại trong kho và số lượng sản phẩm đó mới nhập kho. Khi admin chuyển trạng thái sang đã giao thì số lượng sản phẩm tồn kho sẽ trừ đi số lượng sản phẩm nằm trong đơn hàng.
		2.	Kiến trúc của website:
	2.1	Windows Cominucation Foudation (WCF) để xây dựng web service cho ứng dụng web và winforms.
	2.2	ASP.NET để xây dựng website MVCMobile.
	2.3	Winforms xây dựng chức năng quản lý cho admin.
	2.4	Kết nối cơ sở dữ liệu thông qua LinQ.
		3.	Thiết kế và chức năng của website:
	3.1	WCF Webservice: cung cấp các service cho website cũng như cho phần quản lý ở Winforms.
	3.2	Webform: Với các chức năng chính là hiển thị, xem chi tiết, tìm kiếm  để khách hàng có thể đặt mua sản phẩm online.
	3.3	Winforms: với các chức năng chính bao gồm: quản lý sản phẩm, quản lý tồn kho, quản lý đơn hàng,quản lý nhập hàng, quản lý danh mục, quản lý người dùng.
		4.	Cách cài đặt và cấu hình:
	-Bước 1: Tạo cơ sở dữ liệu: ta chạy hệ quản trị  CSDL MS SQL Server và tạo  một database mới với tên Mobile, sau đó chạy file script Mobile.sql có đính kèm trong thư mục “Database” để tạo dữ liệu các bảng và thêm dữ liệu vào các bảng của database.
	-Bước 2: Cấu hình connection String trong Solution WcfServiceLibrary. Ta chạy chương trình Visual Studio rồi mở solution WcfServiceLibrary lên, trong Solution có file App.config, ta chỉnh sửa nội dung <connectionString> trong file cho đúng với cấu hình của máy mình.

