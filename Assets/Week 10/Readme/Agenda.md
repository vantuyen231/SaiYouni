# Agenda Phát Triển Game Week 10

## 1. Để Tạo Ra 2 Music Background

- **Music Background 1**:

  - Yêu cầu AI tạo ra một bản nhạc nền phù hợp với bối cảnh căng thẳng, gay cấn khi người chơi đang khám phá hoặc chiến đấu.
  - Đảm bảo nhạc nền có nhịp độ nhanh, tạo cảm giác hồi hộp và phấn khích cho người chơi.

- **Music Background 2**:

  - Yêu cầu AI tạo ra một bản nhạc nền thư giãn hơn, thích hợp cho các phân cảnh ít hành động, nơi người chơi khám phá hoặc tương tác với các yếu tố không mang tính chiến đấu.
  - Nhạc nền nhẹ nhàng, mang tính chất khám phá và tạo cảm giác thoải mái.

- **Tích Hợp Vào Game**:
  - Tải và tích hợp 2 bản nhạc nền vào game.
  - Thiết lập trigger để chuyển đổi giữa các bản nhạc nền tùy theo ngữ cảnh (ví dụ: khi chiến đấu hoặc khi khám phá).

## 2. Lồng Tiếng Cho Tất Cả Bẫy Trong Game

- **Xác Định Các Bẫy Cần Lồng Tiếng**:

  - Lập danh sách các loại bẫy có trong game, như bẫy chông, bẫy lửa, bẫy đá lăn, bẫy laser, v.v.
  - Xác định hành động cụ thể của mỗi bẫy cần âm thanh: kích hoạt bẫy, va chạm với người chơi, phát nổ, v.v.

- **Tạo Hoặc Tải Âm Thanh Phù Hợp**:

  - Sử dụng AI hoặc tải âm thanh phù hợp từ các nguồn cung cấp âm thanh như FreeSound, Zapsplat.
  - Đảm bảo mỗi bẫy có một hiệu ứng âm thanh riêng biệt, ví dụ:
    - Bẫy chông: âm thanh kim loại sắc bén.
    - Bẫy lửa: âm thanh rực cháy hoặc phun lửa.
    - Bẫy đá lăn: âm thanh ầm ầm của đá lớn lăn trên mặt đất.

- **Lồng Tiếng Cho Các Bẫy**:

  - Tích hợp âm thanh vào từng bẫy trong game.
  - Sử dụng trigger hoặc sự kiện khi người chơi tương tác với bẫy để phát âm thanh đúng thời điểm (khi bẫy kích hoạt, gây sát thương, hoặc tấn công người chơi).

- **Kiểm Tra Và Điều Chỉnh**:
  - Chạy thử các bẫy để kiểm tra âm thanh lồng tiếng có phát đúng lúc và phù hợp với hành động của bẫy.
  - Điều chỉnh âm lượng, tần suất phát âm thanh để tránh bị trùng lặp hoặc quá ồn.
