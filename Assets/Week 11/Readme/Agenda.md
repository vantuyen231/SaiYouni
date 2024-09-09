# Agenda Phát Triển Game Week 11

## 1. Release Game Lên Itch.io: Downloadable

### Bước 1: Chuẩn Bị File Game

- **Build game** cho nền tảng mà bạn muốn phát hành (Windows, macOS, Linux).
- Đảm bảo rằng file game đã được đóng gói dưới dạng .zip, .exe hoặc file tương ứng với hệ điều hành.

### Bước 2: Tạo Tài Khoản Và Dự Án Trên Itch.io

- **Đăng nhập hoặc tạo tài khoản** trên [itch.io](https://itch.io).
- Truy cập vào **Dashboard** và chọn **Create New Project**.
- Điền thông tin chi tiết về game (tên game, mô tả, các thẻ tag).

### Bước 3: Tải File Game Lên

- Trong phần **Kind of project**, chọn **Downloadable**.
- **Tải file game** của bạn lên trong phần **Uploads** bằng cách nhấp vào nút **Upload files**.
- Đảm bảo rằng bạn đã tải lên đúng phiên bản .zip hoặc các định dạng tệp khác của game.

### Bước 4: Cấu Hình Và Đặt Giá (Nếu Có)

- Nếu bạn muốn game của mình **miễn phí**, hãy giữ giá ở mức $0.00. Nếu không, bạn có thể thiết lập một mức giá cho game của mình.
- Thiết lập các tùy chọn khác như **Early Access** hoặc **Donation** nếu bạn muốn người chơi ủng hộ thêm.

### Bước 5: Kiểm Tra Và Xuất Bản

- **Kiểm tra lại tất cả thông tin** và file tải lên trước khi xuất bản.
- Nhấn **Publish** để phát hành game lên itch.io.

## 2. Release Game Lên Itch.io: WebGL

### Bước 1: Build Game Cho WebGL

- Mở Unity, chọn **File > Build Settings**.
- Trong cửa sổ Build Settings, chọn **WebGL** và nhấn **Switch Platform**.
- Sau đó, nhấn **Build** và chọn thư mục để lưu trữ file WebGL đã build (bao gồm thư mục `Build`, `TemplateData` và file `index.html`).

### Bước 2: Tạo Dự Án Mới Trên Itch.io

- Truy cập vào **Dashboard** của itch.io và chọn **Create New Project**.
- Điền thông tin chi tiết về game (tên game, mô tả, các thẻ tag, ảnh đại diện).

### Bước 3: Tải File WebGL Lên

- Trong phần **Kind of project**, chọn **HTML** để hỗ trợ tải game dạng WebGL.
- Nén tất cả các file trong thư mục WebGL build (bao gồm cả thư mục `Build` và file `index.html`) vào một file **.zip**.
- Tải lên file **.zip** đã nén trong phần **Uploads** bằng cách nhấn **Upload files**.
- Itch.io sẽ tự động nhận diện tệp `index.html` để chạy game trực tiếp trên web.

### Bước 4: Cấu Hình Và Tùy Chọn WebGL

- Kiểm tra xem **Embed options** đã được bật đúng cách cho WebGL hay chưa.
- Bạn có thể thiết lập **iframe size** (kích thước khung chạy game) trong phần tùy chọn hiển thị.

### Bước 5: Kiểm Tra Và Xuất Bản

- **Chạy thử game trực tiếp** trên trình duyệt thông qua itch.io để đảm bảo game hoạt động mượt mà.
- Nhấn **Publish** để phát hành game lên itch.io cho mọi người chơi trực tiếp trên trình duyệt.

## Kết Luận

- Khi phát hành cả hai phiên bản **Downloadable** và **WebGL**, bạn có thể cung cấp nhiều tùy chọn cho người chơi lựa chọn cách chơi game phù hợp với họ.
- Itch.io cung cấp một nền tảng dễ sử dụng và có tính tương tác cao, giúp bạn phát hành và quảng bá game của mình một cách hiệu quả.
