# 5 Loại Giải Thuật Sắp Xếp Khác Nhau

## Giới Thiệu

Sắp xếp là một trong những thao tác cơ bản và quan trọng trong lập trình và khoa học máy tính. Có nhiều giải thuật sắp xếp khác nhau, mỗi giải thuật có ưu và nhược điểm riêng, phù hợp với các tình huống khác nhau.

## 1. Trả lời 1
## Bubble Sort (Sắp xếp nổi bọt)
Bubble Sort là một thuật toán đơn giản nhưng không hiệu quả cho danh sách lớn. Nó hoạt động bằng cách lặp qua danh sách và hoán đổi các phần tử nếu chúng không đúng thứ tự.
**Ưu điểm**
- Dễ hiểu, dễ triển khai.
- Tốt cho danh sách nhỏ hoặc gần như đã sắp xếp.
**Nhược điểm:**
- Hiệu suất kém với danh sách lớn (O(n²)).


## 2. Trả lời 2
## 2. Selection Sort (Sắp xếp chọn)

Selection Sort tìm phần tử nhỏ nhất trong danh sách và đưa nó về đúng vị trí, sau đó tiếp tục với phần còn lại của danh sách.

**Ưu điểm:**
- Ít hoán đổi hơn Bubble Sort.

**Nhược điểm:**
- Vẫn có độ phức tạp O(n²), không phù hợp với danh sách lớn.


## 3. Trả lời 3
## 3. Insertion Sort (Sắp xếp chèn)

Insertion Sort xây dựng danh sách đã sắp xếp bằng cách chèn từng phần tử vào vị trí đúng.

**Ưu điểm:**
- Hoạt động tốt với danh sách nhỏ hoặc gần sắp xếp.
- Độ phức tạp O(n) trong trường hợp danh sách đã gần đúng thứ tự.

**Nhược điểm:**
- Hiệu suất thấp với danh sách lớn (O(n²)).


## 4. Trả lời 4
## 4. Merge Sort (Sắp xếp trộn)

Merge Sort sử dụng kỹ thuật chia để trị, chia danh sách thành hai phần, sắp xếp từng phần và hợp nhất chúng lại.

**Ưu điểm:**
- Ổn định, có hiệu suất O(n log n) trong mọi trường hợp.
- Tốt cho danh sách lớn.

**Nhược điểm:**
- Cần bộ nhớ phụ để lưu danh sách tạm.


## 5. Trả lời 5
## 5. Quick Sort (Sắp xếp nhanh)

Quick Sort cũng sử dụng chia để trị nhưng chọn một phần tử làm chốt (pivot), sau đó chia danh sách thành hai phần và sắp xếp từng phần.

**Ưu điểm:**
- Nhanh hơn Merge Sort trong thực tế.
- Không cần bộ nhớ phụ.

**Nhược điểm:**
- Trường hợp xấu nhất có thể là O(n²), nhưng trung bình vẫn là O(n log n).


# Thuật toán thêm khác với thuật toán đã học

## Trả lời
