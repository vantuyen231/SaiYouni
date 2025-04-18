using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANDPractice : MonoBehaviour
{
    // Start is called before the first frame update
    //Bai 1 -------------
    // Nhập tuổi, giấy phép lái xe, và kinh nghiệm lái xe
    [SerializeField] protected int age = 23;
    [SerializeField] protected bool banglai = false;
    [SerializeField] protected int expYear = 3;

    //Bai 2 -----------------
    // Nhập thông tin về vé, đã đăng ký trước, và tiền sử bệnh tim
    [SerializeField] protected bool hasTicket = true;
    [SerializeField] protected bool preRegistered = true;
    [SerializeField] protected bool hasHeartCondition = false;

    //Bai 3 -----------------
    // Nhập điểm trung bình, điểm hoạt động ngoại khóa, và kiểm tra kỷ luật
    [SerializeField] protected float GPA = 9f;
    [SerializeField] protected float activitiesScore = 8f;
    [SerializeField] protected bool noDiscipline1 = true;

    //Bai 4 -----------------
    // Nhập thông tin email, xác nhận qua điện thoại, và phí tham gia
    [SerializeField] protected bool validEmail = true;
    [SerializeField] protected bool acphoneConfirmed = true;
    [SerializeField] protected bool paidFee = true;


    //Bai 5 -----------------
    // Nhập điểm tổng kết, số môn thi trượt, và điểm chuyên cần
    float finalScore = 4.8f;
    int failedSubjects = 2;
    float attendanceRate = 80.0f;


    //Bai 6 -----------------
    // Nhập thông tin về bằng đại học, kinh nghiệm và bài kiểm tra năng lực
    bool graduated = true;
    int yearsExperience = 3;
    bool passedTest = true;


    //Bai 7 -----------------
    // Nhập số tiền hiện có, kiểm tra hàng trong kho và chương trình khuyến mãi
    bool hasEnoughMoney = true;
    bool inStock = true;
    bool eligiblePromotion = true;


    //Bai 8 -----------------
    // Nhập thông tin về nhiệm vụ hoàn thành, điểm trung bình nhiệm vụ, và đăng nhập hệ thống
    int missionsCompleted = 12;
    float missionAvgScore = 8.1f;
    bool loggedInLast7Days = true;


    //Bai 9 -----------------
    // Nhập số năm làm việc, chỉ tiêu công việc và vi phạm kỷ luật
    int yearsWorked = 6;
    bool metTargets = true;
    bool noDiscipline2 = true;


    //Bai 10 -----------------
    // Nhập tuổi, trạng thái thành viên VIP, và số lần mua vé trong năm
    int age10 = 65;
    bool isVIP = true;
    int ticketsPurchasedThisYear = 3;





    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra tuổi, giấy phép, và kinh nghiệm
        BaiTap2(); // Kiểm tra điều kiện vào công viên giải trí
        BaiTap3(); // Điều kiện đạt học bổng
        BaiTap4(); // Kiểm tra đăng ký hợp lệ
        BaiTap5(); // Kiểm tra điều kiện thi lại
        BaiTap6(); // Xét tuyển nhân viên
        BaiTap7(); // Kiểm tra điều kiện mua hàng
        BaiTap8(); // Đủ điều kiện nhận phần thưởng
        BaiTap9(); // Kiểm tra điều kiện thăng chức
        BaiTap10(); // Điều kiện nhận vé miễn phí
    }

    // Bài Tập 1: Kiểm Tra Tuổi, Giấy Phép, Và Kinh Nghiệm
    void BaiTap1()
    {
        // Kiểm tra nếu người dùng trên 18 tuổi, có giấy phép lái xe, và có kinh nghiệm trên 1 năm
        if (age > 18 && banglai && expYear > 1)
        {
            Debug.Log("Bai 1: Du dieu kien lai xe");
        }
        else
        {
            Debug.Log("Bai 1: Khong du dieu kien lai xe");
        }
    }

    // Bài Tập 2: Kiểm Tra Điều Kiện Vào Công Viên Giải Trí
    void BaiTap2()
    {
        // Kiểm tra nếu người dùng có vé, đã đăng ký trước, và không có tiền sử bệnh tim
        if (hasTicket  && preRegistered && hasHeartCondition)
        {
            Debug.Log("Bai 2: Duoc vao cong vien giai tri");
        }
        else
        {
            Debug.Log("Bai 1: Khong duoc vao cong vien giai tri");
        }
    }

    // Bài Tập 3: Điều Kiện Đạt Học Bổng
    void BaiTap3()
    {
        // Kiểm tra nếu điểm trung bình >= 9.0, điểm ngoại khóa >= 8.0, và không vi phạm kỷ luật
        if (GPA >= 9.0 && activitiesScore  >= 8.0 && noDiscipline1)
        {
            Debug.Log("Bai 3: Dat hoc bong");
        }
        else
        {
            Debug.Log("Bai 3: Khong dat hoc bong");
        }
    }

    // Bài Tập 4: Kiểm Tra Đăng Ký Hợp Lệ
    void BaiTap4()
    {
        // Kiểm tra nếu email hợp lệ, đã xác nhận qua điện thoại, và đã thanh toán phí tham gia
        if (validEmail && acphoneConfirmed && paidFee)
            Debug.Log("Bài 4: Đăng ký hợp lệ.");
        else
            Debug.Log("Bài 4: Đăng ký KHÔNG hợp lệ.");

    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Thi Lại
    void BaiTap5()
    {
        // Kiểm tra nếu điểm tổng kết < 5.0, số môn trượt <= 2, và điểm chuyên cần > 75%
        if (finalScore < 5.0f && failedSubjects <= 2 && attendanceRate > 75.0f)
            Debug.Log("Bài 5: Được phép thi lại.");
        else
            Debug.Log("Bài 5: KHÔNG được phép thi lại.");
    }

    // Bài Tập 6: Xét Tuyển Nhân Viên
    void BaiTap6()
    {
        // Kiểm tra nếu ứng viên đã tốt nghiệp đại học, có ít nhất 2 năm kinh nghiệm, và vượt qua bài kiểm tra năng lực
        if (graduated && yearsExperience >= 2 && passedTest)
            Debug.Log("Bài 6: Được tuyển dụng.");
        else
            Debug.Log("Bài 6: KHÔNG được tuyển dụng.");
    }

    // Bài Tập 7: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap7()
    {
        // Kiểm tra nếu người dùng có đủ tiền, có hàng trong kho, và đủ điều kiện tham gia khuyến mãi
        if (hasEnoughMoney && inStock && eligiblePromotion)
            Debug.Log("Bài 7: Có thể mua sản phẩm.");
        else
            Debug.Log("Bài 7: KHÔNG thể mua sản phẩm.");
    }

    // Bài Tập 8: Đủ Điều Kiện Nhận Phần Thưởng
    void BaiTap8()
    {
        // Kiểm tra nếu đã hoàn thành ít nhất 10 nhiệm vụ, điểm nhiệm vụ >= 8, và đăng nhập vào hệ thống trong 7 ngày qua
        if (missionsCompleted >= 10 && missionAvgScore >= 8.0f && loggedInLast7Days)
            Debug.Log("Bài 8: Đủ điều kiện nhận thưởng.");
        else
            Debug.Log("Bài 8: KHÔNG đủ điều kiện nhận thưởng.");
    }

    // Bài Tập 9: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap9()
    {
        // Kiểm tra nếu đã làm việc trên 5 năm, đạt chỉ tiêu công việc và không vi phạm kỷ luật
        if (yearsWorked > 5 && metTargets && noDiscipline2)
            Debug.Log("Bài 9: Đủ điều kiện thăng chức.");
        else
            Debug.Log("Bài 9: KHÔNG đủ điều kiện thăng chức.");
    }

    // Bài Tập 10: Điều Kiện Nhận Vé Miễn Phí
    void BaiTap10()
    {
        // Kiểm tra nếu người dùng trên 60 tuổi, là thành viên VIP, và đã mua vé ít nhất 3 lần trong năm
        if (age10 > 60 && isVIP && ticketsPurchasedThisYear >= 3)
            Debug.Log("Bài 10: Được nhận vé miễn phí.");
        else
            Debug.Log("Bài 10: KHÔNG được nhận vé miễn phí.");
    }
}
