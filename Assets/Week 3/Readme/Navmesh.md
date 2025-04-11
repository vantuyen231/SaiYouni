# Sử Dụng NavMesh Obstacle Trong Unity

## Hỏi AI: Cách Sử Dụng NavMesh Obstacle

### NavMesh Obstacle là gì?

**NavMesh Obstacle** là một thành phần trong Unity được sử dụng để tạo ra các vật cản trong môi trường, ngăn cản các nhân vật hoặc đối tượng điều hướng (navigation) qua những khu vực nhất định. Đối tượng được gắn **NavMesh Obstacle** sẽ trở thành vật cản và có thể tĩnh hoặc động, tùy thuộc vào cách bạn cấu hình nó.


### Trả lời
- NavMesh Obstacle là một component trong Unity giúp tạo vật cản động hoặc cố định để các agent sử dụng NavMesh Agent sẽ né tránh trong quá trình di chuyển.

**Chức năng chính của NavMesh Obstacle**
**Dùng để ngăn cản đường đi của NavMesh Agent.**

**Có 2 chế độ:**
- Carve (Khắc): Cắt lỗ trong NavMesh để agent tự động né tránh.
- Không Carve: Vật thể sẽ không cắt NavMesh nhưng vẫn có thể dùng cho mục đích kiểm tra va chạm khác.

### Tìm hiểu cách sử dụng **NavMesh Obstacle** để chặn đường hoặc tạo vật cản cho các nhân vật điều hướng (navigation) trong game.
1. Chuẩn Bị Scene
**Trước tiên, bạn cần có:**
- Một terrain hoặc plane đã được bake NavMesh (dùng Window → AI → Navigation → Bake).
- Một nhân vật có NavMesh Agent (để nó tự tìm đường).
- Một hoặc nhiều vật thể làm vật cản (obstacle).

2. Thêm NavMesh Obstacle vào Vật Cản
Chọn vật thể bạn muốn dùng làm chướng ngại vật (ví dụ: thùng, hộp, cây...).
**Vào Inspector:**
- Nhấn Add Component → chọn NavMesh Obstacle.
- Cài đặt:
    - Carve: bật để vật thể "khắc" vào NavMesh, giúp nhân vật biết để né.
    - Carve Only Stationary: bật nếu obstacle chỉ khắc NavMesh khi đứng yên (đỡ tốn hiệu năng).
    - Shape: Chọn Box hoặc Capsule tùy hình dạng obstacle.
    - Center/Size: điều chỉnh vùng ảnh hưởng.

### Xem xét cách thiết lập các thuộc tính như "carving" để nhân vật tránh hoặc phản ứng linh hoạt với vật cản.
**Thiết lập "Carving" để nhân vật né vật cản**
- Carve: bật để obstacle khắc lỗ vào NavMesh, giúp nhân vật tự tránh.
- Carve Only Stationary: bật để chỉ khắc khi obstacle đứng yên → tiết kiệm hiệu năng.
- Dùng script để bật/tắt carving linh hoạt khi obstacle di chuyển rồi dừng lại.
- Điều chỉnh Shape, Size, Center để vùng cản khớp với hình dạng thực tế.

### Kiểm tra và điều chỉnh hệ thống **NavMesh** cho phù hợp với các vật cản mới.
- Khi bạn thêm các vật thể mới vào scene có thể ảnh hưởng đến đường đi của nhân vật (NavMesh Agent), bạn cần thực hiện một số bước để đảm bảo hệ thống điều hướng hoạt động chính xác và ổn định.
1. hêm NavMesh Obstacle cho vật cản
    - Gắn component NavMesh Obstacle vào các vật thể như tường, thùng, xe, cây...
    - Nếu bạn muốn nhân vật tự động né thì cần bật Carve.
    - Nếu không bật Carve, obstacle sẽ không ảnh hưởng đến đường đi trừ khi bạn rebake lại NavMesh.
    
2. Carve: ảnh hưởng thời gian thực đến NavMesh
    - Khi bật Carve, obstacle sẽ "cắt lỗ" trên NavMesh trong lúc runtime, giúp NavMesh Agent tự động tránh.
    - Thường dùng cho các vật thể có thể thay đổi hoặc di chuyển như cửa, NPC tạm thời đứng yên, thùng rơi xuống...

3. Rebake NavMesh nếu không dùng Carve
    - Nếu bạn thêm vật cản cố định (không bật Carve), bạn cần vào:
    - Window → AI → Navigation → Bake
    - Nhấn Bake lại NavMesh
    - Điều này cập nhật bản đồ đường đi để phản ánh chính xác vị trí và kích thước obstacle mới.

4. Kiểm tra lại đường đi của nhân vật
    - Sau khi thêm obstacle, chạy game và quan sát hành vi của NavMesh Agent:
    - Agent có bị kẹt không?    
    - Có đi xuyên vật không?
    - Có tự động né vật cản như mong muốn không?
    - Dùng NavMesh Debug (gõ NavMeshSurface hoặc bật gizmos) để xem trực tiếp vùng NavMesh đã bị khắc hay chưa.

5. Tối ưu hiệu năng
    - Nếu có nhiều obstacle di chuyển, chỉ nên bật Carve khi thực sự cần.
    - Dùng Carve Only Stationary để ngăn obstacle liên tục cập nhật NavMesh khi đang di chuyển.