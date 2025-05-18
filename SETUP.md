
# SETUP.md – Hướng Dẫn Cài Đặt Môi Trường Lập Trình C# .NET

## 🧰 1. Yêu cầu hệ thống

- **Hệ điều hành hỗ trợ**:
  - Windows 10/11
  - macOS 10.15 trở lên
  - Ubuntu/Linux (nên dùng Ubuntu 20.04+)

## 🧱 2. Cài đặt .NET SDK

### ▶ Windows / macOS / Linux

1. Truy cập trang chính thức:  
   👉 https://dotnet.microsoft.com/en-us/download

2. Tải và cài đặt phiên bản mới nhất của:
   - [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet)

   ⚠️ Yêu cầu .NET SDK 6.0 trở lên (ưu tiên dùng bản LTS).

3. Sau khi cài đặt, mở Terminal (Command Prompt/PowerShell/macOS Terminal) và kiểm tra:
   ```bash
   dotnet --version
   ```

   Kết quả ví dụ: `6.0.416`

## 🧑‍💻 3. Cài đặt Visual Studio Code

1. Tải tại: https://code.visualstudio.com/

2. Sau khi cài xong, mở VS Code và cài các **tiện ích mở rộng** (extensions) sau:

   - ✅ **C# for Visual Studio Code** (by Microsoft)  
     👉 Hỗ trợ biên dịch, IntelliSense và debug C#
   - ✅ **.NET Install Tool**
   - ✅ **GitLens** (nếu bạn muốn dùng Git)

## 🧪 4. Kiểm tra chạy thử project đầu tiên

1. Tạo một thư mục test:
   ```bash
   mkdir HelloWorldApp
   cd HelloWorldApp
   ```

2. Tạo project C#:
   ```bash
   dotnet new console
   ```

3. Chạy thử:
   ```bash
   dotnet run
   ```

   Kết quả: `Hello, World!`

## 🔗 5. Hướng dẫn cài Git (nếu chưa có)

1. Tải Git:  
   👉 https://git-scm.com/downloads

2. Kiểm tra Git:
   ```bash
   git --version
   ```

3. Cấu hình Git lần đầu:
   ```bash
   git config --global user.name "Tên của bạn"
   git config --global user.email "email@example.com"
   ```

## ✅ Kiểm tra nhanh môi trường đã sẵn sàng

| Công cụ       | Lệnh kiểm tra         | Kết quả mong đợi         |
|---------------|------------------------|----------------------------|
| .NET SDK      | `dotnet --version`     | Ví dụ: `6.0.416`          |
| Git           | `git --version`        | Ví dụ: `git version 2.43` |
| VS Code       | Mở bằng `code .`       | VS Code mở thư mục hiện tại |

---

Nếu bạn gặp lỗi hoặc cần hỗ trợ cài đặt, hãy tạo issue trong repo hoặc liên hệ người hướng dẫn.
