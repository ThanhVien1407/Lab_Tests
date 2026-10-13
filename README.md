# Bài Thực Hành Trên Lớp - C#

Đây là kho lưu trữ (repository) chứa các bài tập thực hành môn Tin học cơ sở (Information Technology Fundamentals) tại trường Đại học Kinh tế TP.HCM (UEH). 

Dự án được viết bằng ngôn ngữ C# trên nền tảng .NET, tập hợp các bài tập giải quyết vấn đề (Problem Solving) qua từng buổi học trên lớp.
## 👨‍💻 Thông tin sinh viên

* **Họ và tên:** Võ Thanh Viễn
* **MSSV:** 31251025064
* **Trường:** Đại học Kinh tế TP.HCM (UEH)

## 🗂️ Cấu trúc dự án

Dự án được tổ chức theo mô hình tập trung để dễ dàng quản lý và chấm điểm:

* **`_Main.cs`**: Tệp điều khiển trung tâm. Chứa hàm `Main()` duy nhất của toàn bộ dự án, đóng vai trò như một Menu để gọi và chạy các bài tập ở các tệp khác.
* **`Buổi 2.cs`**, **`Buổi 3.cs`**: Các module chứa mã nguồn giải quyết yêu cầu bài toán của từng buổi học cụ thể (ví dụ: chuyển đổi nhiệt độ, xử lý dữ liệu...).
* **`Problem Solving.cs`**: Tệp chứa các thuật toán và bài tập tự luyện thêm.

## 🚀 Hướng dẫn cách chạy dự án

1. Clone repository này về máy tính cục bộ.
2. Mở tệp Solution (`.sln`) bằng **Visual Studio 2022**.
3. Mở tệp `_Main.cs`.
4. Tìm đến đoạn code gọi hàm và bỏ ghi chú (uncomment) bài tập bạn muốn kiểm tra.
   ```csharp
   // Ví dụ:
   Buoi2.Baitap01();
