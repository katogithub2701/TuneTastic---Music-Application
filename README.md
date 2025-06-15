# TuneTastic - Music Player

TuneTastic là ứng dụng nghe nhạc hiện đại dành cho Windows, phát triển bằng C# WinForms, hỗ trợ quản lý, phát nhạc, tạo playlist, tìm kiếm và nhiều tính năng tiện ích khác.

## Tính năng chính
- Đăng ký, đăng nhập người dùng
- Quản lý, phát nhạc, tạm dừng, chuyển bài, lặp, phát ngẫu nhiên
- Tạo, chỉnh sửa, xóa playlist cá nhân
- Tìm kiếm bài hát, nghệ sĩ, playlist
- Quản lý thông tin nghệ sĩ, bộ sưu tập nhạc
- Giao diện đẹp, dễ sử dụng

## Cấu trúc thư mục
- `TuneTastic---Music-Application/` - Project chính, mã nguồn ứng dụng WinForms
  - `Music Application/` - Source code chính (BLL, DAL, DTO, GUI, Entity Framework, ...)
- `App/` - Các project thử nghiệm/phụ
- `database.sql`, `databaseMusicApp.sql` - File mẫu cấu trúc database SQL Server
- `white/`, `githubres/Roboto/` - Icon, font, tài nguyên giao diện

## Hướng dẫn cài đặt & chạy ứng dụng
1. Cài đặt **Visual Studio** (khuyến nghị 2019 trở lên) và **.NET Framework 4.7.2**
2. Khôi phục database:
   - Tạo database mới trên SQL Server, chạy script trong `databaseMusicApp.sql` hoặc `database.sql`
   - Cập nhật chuỗi kết nối trong file `App.config` hoặc `Music Application/App.config` nếu cần
3. Mở solution `TuneTastic---Music-Application/Music Application.sln` bằng Visual Studio
4. Build và chạy project

## Thông tin database
- Sử dụng Entity Framework, các bảng chính: `Users`, `Musics`, `Artists`, `Collections`, `Playlists`
- Có thể chỉnh sửa script SQL để phù hợp với môi trường của bạn
---
