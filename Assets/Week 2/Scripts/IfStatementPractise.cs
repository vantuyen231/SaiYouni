using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatementPractise : MonoBehaviour
{
    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra số dương, âm, hoặc bằng 0
        BaiTap2(); // Kiểm tra số chẵn hay lẻ
        BaiTap3(); // Kiểm tra điều kiện thi đỗ
        BaiTap4(); // Tìm số lớn nhất trong hai số
        BaiTap5(); // Kiểm tra điều kiện mua hàng
        BaiTap6(); // Kiểm tra năm nhuận
        BaiTap7(); // Tính giá vé xem phim
        BaiTap8(); // Kiểm tra học sinh xuất sắc
        BaiTap9(); // So sánh ba số
        BaiTap10(); // Tính tiền lương
        BaiTap11(); // Kiểm tra điều kiện vào câu lạc bộ
        BaiTap12(); // Phân loại học sinh
        BaiTap13(); // Tính tiền điện
        BaiTap14(); // Kiểm tra điều kiện thăng chức
        BaiTap15(); // Kiểm tra điều kiện miễn phí vận chuyển
        BaiTap16(); // Tính thuế thu nhập cá nhân
        BaiTap17(); // Tính điểm trung bình của môn học
        BaiTap18(); // Kiểm tra điều kiện nhập hàng
        BaiTap19(); // Tìm số lớn hơn 10
        BaiTap20(); // Kiểm tra điều kiện đăng ký khóa học
    }

    // Bài Tập 1: Kiểm Tra Số Dương, Âm Hoặc Bằng 0
    void BaiTap1()
    {
        // Nhập một số từ bàn phím
        // Kiểm tra xem số đó là số dương, âm hay bằng 0
    }

    // Bài Tập 2: Kiểm Tra Số Chẵn Hay Lẻ
    void BaiTap2()
    {
        // Nhập một số từ bàn phím
        // Kiểm tra xem số đó là số chẵn hay lẻ
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Thi Đỗ
    void BaiTap3()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        // Kiểm tra nếu điểm trung bình >= 5.0 thì học sinh đỗ, ngược lại thì trượt
    }

    // Bài Tập 4: Tìm Số Lớn Nhất Trong Hai Số
    void BaiTap4()
    {
        // Nhập hai số nguyên từ bàn phím
        // Kiểm tra và in ra số lớn nhất trong hai số đó
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap5()
    {
        // Nhập số tiền hiện có và giá sản phẩm từ bàn phím
        // Kiểm tra xem người dùng có đủ tiền mua hàng không
    }

    // Bài Tập 6: Kiểm Tra Năm Nhuận
    void BaiTap6()
    {
        // Nhập một năm từ bàn phím
        // Kiểm tra xem năm đó có phải là năm nhuận hay không
    }

    // Bài Tập 7: Tính Giá Vé Xem Phim
    void BaiTap7()
    {
        // Nhập tuổi của người mua vé từ bàn phím
        // Nếu người mua dưới 18 tuổi, giá vé là 50,000 đồng
        // Nếu người mua từ 18 tuổi trở lên, giá vé là 100,000 đồng
    }

    // Bài Tập 8: Kiểm Tra Học Sinh Xuất Sắc
    void BaiTap8()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        // Kiểm tra xem học sinh có đạt danh hiệu xuất sắc không (điểm trung bình >= 9.0)
    }

    // Bài Tập 9: So Sánh Ba Số
    void BaiTap9()
    {
        // Nhập ba số nguyên từ bàn phím
        // Kiểm tra và in ra số lớn nhất trong ba số đó
    }

    // Bài Tập 10: Tính Tiền Lương
    void BaiTap10()
    {
        // Nhập số giờ làm việc và mức lương cố định từ bàn phím
        // Nếu nhân viên làm trên 40 giờ, lương được tính thêm giờ
        // Nếu làm dưới hoặc bằng 40 giờ, lương tính theo giờ cố định
    }

    // Bài Tập 11: Kiểm Tra Điều Kiện Vào Câu Lạc Bộ
    void BaiTap11()
    {
        // Nhập tuổi và kiểm tra xem người đó có thẻ thành viên hay không
        // Kiểm tra nếu trên 18 tuổi và có thẻ thành viên thì được vào câu lạc bộ
    }

    // Bài Tập 12: Phân Loại Học Sinh
    void BaiTap12()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        // Phân loại học sinh theo thang điểm từ xuất sắc đến yếu
    }

    // Bài Tập 13: Tính Tiền Điện
    void BaiTap13()
    {
        // Nhập số điện tiêu thụ từ bàn phím
        // Tính tiền điện theo công thức: <= 100 kWh: 1,500 đồng/kWh, >100 kWh: 2,000 đồng/kWh
    }

    // Bài Tập 14: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap14()
    {
        // Nhập số năm làm việc và đánh giá công việc
        // Kiểm tra nếu số năm làm việc trên 5 năm và đánh giá tốt thì đủ điều kiện thăng chức
    }

    // Bài Tập 15: Kiểm Tra Điều Kiện Miễn Phí Vận Chuyển
    void BaiTap15()
    {
        // Nhập giá trị đơn hàng từ bàn phím
        // Kiểm tra nếu giá trị đơn hàng >= 500,000 đồng thì được miễn phí vận chuyển
    }

    // Bài Tập 16: Tính Thuế Thu Nhập Cá Nhân
    void BaiTap16()
    {
        // Nhập thu nhập từ bàn phím
        // Tính thuế thu nhập cá nhân dựa trên mức thu nhập
    }

    // Bài Tập 17: Tính Điểm Trung Bình Của Môn Học
    void BaiTap17()
    {
        // Nhập điểm của 3 bài kiểm tra từ bàn phím
        // Tính điểm trung bình và kiểm tra xem học sinh có đạt yêu cầu hay không (>= 5.0)
    }

    // Bài Tập 18: Kiểm Tra Điều Kiện Nhập Hàng
    void BaiTap18()
    {
        // Nhập số lượng hàng hiện tại và kiểm tra khả năng nhập thêm hàng (dưới 100 và còn chỗ)
    }

    // Bài Tập 19: Tìm Số Lớn Hơn 10
    void BaiTap19()
    {
        // Nhập một số từ bàn phím
        // Kiểm tra xem số đó có lớn hơn 10 hay không
    }

    // Bài Tập 20: Kiểm Tra Điều Kiện Đăng Ký Khóa Học
    void BaiTap20()
    {
        // Nhập điểm tổng kết và các điều kiện khác từ bàn phím
        // Kiểm tra xem học sinh có đủ điều kiện đăng ký khóa học nâng cao không
    }
}
