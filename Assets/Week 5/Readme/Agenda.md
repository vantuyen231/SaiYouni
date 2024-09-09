# Agenda Phát Triển Game Week 5

## 1. Kỹ Thuật Spawner<T> Có Tên Gọi Là Gì

- **Spawner<T>** là một kỹ thuật sử dụng **Generics** trong C#. Nó cho phép tạo ra các đối tượng (objects) một cách linh hoạt và có thể tái sử dụng mà không cần chỉ định cụ thể kiểu dữ liệu ngay từ đầu.
- **Generic Spawner** là thuật ngữ được dùng để chỉ kỹ thuật này. Nó giúp giảm sự phụ thuộc vào các lớp hoặc đối tượng cụ thể, cho phép sinh ra nhiều kiểu đối tượng khác nhau thông qua một class generic duy nhất.

## 2. Bài Tập Sử Dụng `<T>`

1.  **Bài tập 1**: Tạo một lớp generic lưu trữ dữ liệu của bất kỳ kiểu dữ liệu nào, ví dụ như `int`, `float`, hoặc `string`.
2.  **Bài tập 2**: Viết hàm generic trả về phần tử lớn nhất trong một mảng các phần tử có kiểu dữ liệu bất kỳ.
3.  **Bài tập 3**: Viết hàm generic để hoán đổi giá trị của hai biến với bất kỳ kiểu dữ liệu nào.
4.  **Bài tập 4**: Tạo một lớp generic để quản lý danh sách các đối tượng khác nhau và có phương thức thêm, xóa đối tượng từ danh sách.
5.  **Bài tập 5**: Tạo một phương thức generic kiểm tra xem một phần tử bất kỳ có tồn tại trong danh sách hoặc mảng hay không.

## 3. Tạo Animation Hit Cho Thêm 5 Characters

- **Tạo Animation Hit**:

  - Tạo 5 animation **Hit** mới cho các nhân vật khác nhau.
  - Mỗi nhân vật sẽ có một animation hit riêng biệt thể hiện khi bị tấn công.

- **Gắn Animation Hit**:

  - Tích hợp animation hit vào hệ thống Animator của từng nhân vật.
  - Đảm bảo rằng khi nhân vật nhận sát thương, animation hit sẽ được kích hoạt một cách chính xác.

- **Kiểm Tra Hoạt Động**:
  - Chạy thử và kiểm tra quá trình hoạt động của animation hit cho từng nhân vật để đảm bảo tính mượt mà và logic.

## 4. Tạo Animation Dying Cho Thêm 5 Characters

- **Tạo Animation Dying**:

  - Thiết kế và tạo 5 animation **Dying** cho các nhân vật khi chúng chết.
  - Mỗi nhân vật sẽ có một kiểu chết riêng biệt phù hợp với đặc điểm của từng nhân vật.

- **Gắn Animation Dying**:

  - Tích hợp animation dying vào hệ thống Animator của từng nhân vật.
  - Đảm bảo rằng khi HP của nhân vật về 0, animation dying sẽ được kích hoạt đúng cách.

- **Kiểm Tra Animation**:
  - Chạy thử và kiểm tra animation dying trên từng nhân vật để đảm bảo sự chuyển tiếp mượt mà từ trạng thái sống sang trạng thái chết.

## 5. Gắn Ragdolls Cho Thêm 5 Characters

- **Tạo Ragdoll Cho 5 Nhân Vật**:

  - Sử dụng **Ragdoll Wizard** trong Unity để tạo ragdolls cho 5 nhân vật khác nhau.

- **Gắn Kết Ragdoll Vào Nhân Vật**:

  - Tích hợp ragdolls vào các nhân vật để khi nhân vật chết, ragdoll sẽ được kích hoạt, tạo ra hiệu ứng vật lý thực tế.

- **Điều Chỉnh Và Kiểm Tra Ragdolls**:
  - Điều chỉnh các yếu tố vật lý của ragdoll (trọng lượng, lực va chạm, tốc độ rơi) để phù hợp với từng nhân vật.
  - Kiểm tra hoạt động của ragdoll khi nhân vật chết hoặc va chạm để đảm bảo tính chân thực và mượt mà.
