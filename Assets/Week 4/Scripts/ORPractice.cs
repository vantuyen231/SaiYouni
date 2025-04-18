using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ORPractice : MonoBehaviour
{
    // Start is called before the first frame update
    //Bai 1 ----------------
    [SerializeField] protected bool hasValidTicket = false;
    [SerializeField] protected bool isVIP1 = true;
    [SerializeField] protected bool invitedByOrganizer = false;

    //Bai 2 ----------------
    [SerializeField] protected int userTicket = 123;
    [SerializeField] protected int prize1 = 555;
    [SerializeField] protected int prize2 = 123;
    [SerializeField] protected int prize3 = 999;

    //Bai 3 ----------------
    [SerializeField] protected bool hasStableIncome = false;
    [SerializeField] protected bool hasCollateral = true;
    [SerializeField] protected bool hasGuarantor = false;

    //Bai 4 ----------------
    [SerializeField] protected bool excellentGrades = false;
    [SerializeField] protected bool activeInClubs = false;
    [SerializeField] protected bool fromLowIncomeFamily = true;

    //Bai 5 ----------------
    [SerializeField] protected bool validEmail = false;
    [SerializeField] protected bool verifiedPhone = false;
    [SerializeField] protected bool registeredOnline = true;

    //Bai 6 ----------------
    [SerializeField] protected bool hasDriverLicense = true;
    [SerializeField] protected bool vehicleRegistered = false;
    [SerializeField] protected bool hasInsurance = false;

    //Bai 7 ----------------
    [SerializeField] protected bool isAdmin = false;
    [SerializeField] protected bool approvedByManager = true;
    [SerializeField] protected bool hasAccessCode = false;

    //Bai 8 ----------------
    [SerializeField] protected bool hasRecommendation = false;
    [SerializeField] protected bool passedEntranceTest = true;
    [SerializeField] protected bool hasExperience = false;

    //Bai 9 ----------------
    [SerializeField] protected bool hasPromoCode = false;
    [SerializeField] protected bool isVIP9 = true;
    [SerializeField] protected bool isFreeNow = false;

    //Bai 10 ----------------
    [SerializeField] protected bool spentEnough = true;
    [SerializeField] protected bool isLoyalCustomer = false;
    [SerializeField] protected bool hasPromotion = false;

    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra vé vào cửa
        BaiTap2(); // Điều kiện trúng thưởng
        BaiTap3(); // Kiểm tra điều kiện vay tiền
        BaiTap4(); // Điều kiện nhận học bổng
        BaiTap5(); // Kiểm tra đăng ký sự kiện
        BaiTap6(); // Điều kiện lái xe
        BaiTap7(); // Kiểm tra quyền truy cập tài liệu
        BaiTap8(); // Kiểm tra điều kiện tham gia khóa học
        BaiTap9(); // Điều kiện tải ứng dụng miễn phí
        BaiTap10(); // Điều kiện sử dụng dịch vụ đặc biệt
    }

    // Bài Tập 1: Kiểm Tra Vé Vào Cửa
    void BaiTap1()
    {
        // Kiểm tra xem người dùng có thể vào sự kiện nếu có vé hợp lệ, là thành viên VIP, hoặc được mời
        if (hasValidTicket || isVIP1 || invitedByOrganizer)
            Debug.Log("Bài 1: Được vào sự kiện.");
        else
            Debug.Log("Bài 1: KHÔNG được vào sự kiện.");
    }

    // Bài Tập 2: Điều Kiện Trúng Thưởng
    void BaiTap2()
    {
        // Kiểm tra xem người dùng có trúng thưởng nếu số vé của họ trúng giải nhất, nhì, hoặc ba
        if (userTicket == prize1 || userTicket == prize2 || userTicket == prize3)
            Debug.Log("Bài 2: Bạn đã trúng thưởng!");
        else
            Debug.Log("Bài 2: Bạn KHÔNG trúng thưởng.");
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Vay Tiền
    void BaiTap3()
    {
        // Kiểm tra xem người dùng có đủ điều kiện vay tiền nếu có thu nhập ổn định, tài sản thế chấp, hoặc người bảo lãnh
        if (hasStableIncome || hasCollateral || hasGuarantor)
            Debug.Log("Bài 3: Đủ điều kiện vay tiền.");
        else
            Debug.Log("Bài 3: KHÔNG đủ điều kiện vay tiền.");
    }

    // Bài Tập 4: Điều Kiện Nhận Học Bổng
    void BaiTap4()
    {
        // Kiểm tra xem học sinh có nhận được học bổng nếu có thành tích học tập xuất sắc, hoạt động ngoại khóa tốt, hoặc gia đình khó khăn
        if (excellentGrades || activeInClubs || fromLowIncomeFamily)
            Debug.Log("Bài 4: Đủ điều kiện nhận học bổng.");
        else
            Debug.Log("Bài 4: KHÔNG đủ điều kiện nhận học bổng.");
    }

    // Bài Tập 5: Kiểm Tra Đăng Ký Sự Kiện
    void BaiTap5()
    {
        // Kiểm tra xem người dùng có thể đăng ký sự kiện nếu có email hợp lệ, số điện thoại xác thực, hoặc đã đăng ký qua trang web
        if (validEmail || verifiedPhone || registeredOnline)
            Debug.Log("Bài 5: Được đăng ký sự kiện.");
        else
            Debug.Log("Bài 5: KHÔNG được đăng ký sự kiện.");
    }

    // Bài Tập 6: Điều Kiện Lái Xe
    void BaiTap6()
    {
        // Kiểm tra xem người dùng có thể lái xe nếu có bằng lái, đã đăng ký xe hợp lệ, hoặc có bảo hiểm xe
        if (hasDriverLicense || vehicleRegistered || hasInsurance)
            Debug.Log("Bài 6: Được phép lái xe.");
        else
            Debug.Log("Bài 6: KHÔNG được phép lái xe.");
    }

    // Bài Tập 7: Kiểm Tra Quyền Truy Cập Tài Liệu
    void BaiTap7()
    {
        // Kiểm tra xem người dùng có quyền truy cập tài liệu nếu là quản trị viên, được cấp quyền truy cập từ quản lý, hoặc có mã xác thực
        if (isAdmin || approvedByManager || hasAccessCode)
            Debug.Log("Bài 7: Có quyền truy cập tài liệu.");
        else
            Debug.Log("Bài 7: KHÔNG có quyền truy cập tài liệu.");
    }

    // Bài Tập 8: Kiểm Tra Điều Kiện Tham Gia Khóa Học
    void BaiTap8()
    {
        // Kiểm tra xem học sinh có thể tham gia khóa học đặc biệt nếu có thư giới thiệu từ giáo viên, đã hoàn thành bài kiểm tra đầu vào, hoặc có kinh nghiệm liên quan
        if (hasRecommendation || passedEntranceTest || hasExperience)
            Debug.Log("Bài 8: Được tham gia khóa học.");
        else
            Debug.Log("Bài 8: KHÔNG được tham gia khóa học.");
    }

    // Bài Tập 9: Điều Kiện Tải Ứng Dụng Miễn Phí
    void BaiTap9()
    {
        // Kiểm tra xem người dùng có thể tải ứng dụng miễn phí nếu có mã khuyến mãi, là thành viên VIP, hoặc ứng dụng đang trong thời gian miễn phí
        if (hasPromoCode || isVIP9 || isFreeNow)
            Debug.Log("Bài 9: Có thể tải ứng dụng miễn phí.");
        else
            Debug.Log("Bài 9: KHÔNG thể tải ứng dụng miễn phí.");
    }

    // Bài Tập 10: Điều Kiện Sử Dụng Dịch Vụ Đặc Biệt
    void BaiTap10()
    {
        // Kiểm tra xem khách hàng có thể sử dụng dịch vụ đặc biệt nếu đã chi tiêu trên mức yêu cầu, là khách hàng thân thiết, hoặc có chương trình khuyến mãi
        if (spentEnough || isLoyalCustomer || hasPromotion)
            Debug.Log("Bài 10: Có thể sử dụng dịch vụ đặc biệt.");
        else
            Debug.Log("Bài 10: KHÔNG thể sử dụng dịch vụ đặc biệt.");
    }
}
