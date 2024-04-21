## Controller
- Là một lớp kế thừa từ lớp Controller : Microsoft.AspNetCore.MVC.Controller
- Action trong controller là một phương thức public (không được static) 
- Action trả về bất kỳ kiểu dữ liệu nào, thường là IACtionResult
- Các dịch vụ inject vào controller qua hàm tạo
## View
- Là file .cshtml
- View cho Action lưu tại: /View/ControlleName/ActionName.cshtml
- Thêm thư mục lưu trữ view:
```
// {0} -> tên Action
// {1} -> tên Controller
// {3} -> tên Area
options.ViewLocationFormats.Add("/MyView/{1}/{0}" + RazorViewEngine.ViewExtension);
```
## Truyền dữ liệu sang View
- Model
- ViewData
- ViewBag
- TempData
