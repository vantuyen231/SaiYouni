using System;
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
        Console.Write("Nhap 1 so:");
        double number;

        // Kiểm tra xem số đó là số dương, âm hay bằng 0
        if (double.TryParse(Console.ReadLine(), out number))
        {
            if (number > 0)
            {
                Debug.Log("Số bạn nhập là số dương.");
            }
            else if (number < 0)
            {
                Debug.Log("Số bạn nhập là số âm.");
            }
            else
            {
                Debug.Log("Số bạn nhập là 0.");
            }
        }
        else
        {
            Debug.Log("Vui lòng nhập một số hợp lệ!");
        }
    }


    // Bài Tập 2: Kiểm Tra Số Chẵn Hay Lẻ
    void BaiTap2()
    {
        // Nhập một số từ bàn phím
        Console.Write("Nhap 1 so:");
        double number;
        // Kiểm tra xem số đó là số chẵn hay lẻ
        if (double.TryParse(Console.ReadLine(), out number))
        {
            if (number % 2 == 0)
            {
                Debug.Log("Số bạn nhập là số chắn ");
            }
            else Debug.Log("Số bạn nhập là số lẻ");
        }
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Thi Đỗ
    void BaiTap3()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        Console.Write("Nhập số điểm trung bình của học sinh: ");
        float avgScore;

        // Kiểm tra nếu điểm trung bình >= 5.0 thì học sinh đỗ, ngược lại thì trượt
        if (float.TryParse(Console.ReadLine(), out avgScore))
        {
            if (avgScore >= 5f)
            {
                Debug.Log("Học sinh thi đỗ");
            }
            else Debug.Log("Học sinh trượt");
        }
    }

    // Bài Tập 4: Tìm Số Lớn Nhất Trong Hai Số
    void BaiTap4()
    {
        // Nhập hai số nguyên từ bàn phím
        Console.Write("Nhập số thứ nhất ");
        int num1;
        Console.Write("Nhập số thứ hai ");
        int num2;
        // Kiểm tra và in ra số lớn nhất trong hai số đó
        if (int.TryParse(Console.ReadLine(), out num1) && int.TryParse(Console.ReadLine(), out num2))
        {
            int maxNum = (num1 > num2) ? num1 : num2;
            Debug.Log("Số lớn nhất là " + maxNum);
        }
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap5()
    {
        // Nhập số tiền hiện có và giá sản phẩm từ bàn phím
        Console.Write("Nhap gia tri san pham");
        double price;
        Console.Write("Nhap so tien: ");
        double money;
        // Kiểm tra xem người dùng có đủ tiền mua hàng không
        if (double.TryParse(Console.ReadLine(), out price) && double.TryParse(Console.ReadLine(), out money))
        {
            if (money > price)
            {
                Debug.Log("Du tien");
            }
            else
            {
                Debug.Log("Khong du tien");
            }
        }
    }

    // Bài Tập 6: Kiểm Tra Năm Nhuận
    void BaiTap6()
    {
        // Nhập một năm từ bàn phím
        Console.Write("Nhap nam: ");
        double year;
        // Kiểm tra xem năm đó có phải là năm nhuận hay không
        if (double.TryParse(Console.ReadLine(), out year))
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Debug.Log("Nam nhuan");
            }
            else Debug.Log("Khong phai nam nhuan");
        }

    }

    // Bài Tập 7: Tính Giá Vé Xem Phim
    void BaiTap7()
    {
        int adultTicket = 100000;
        int babyTicket = 50000;
        // Nhập tuổi của người mua vé từ bàn phím
        Console.Write("Nhap tuoi cua ban");
        int age;
        // Nếu người mua dưới 18 tuổi, giá vé là 50,000 đồng
        // Nếu người mua từ 18 tuổi trở lên, giá vé là 100,000 đồng
        if (int.TryParse(Console.ReadLine(), out age))
        {
            int ticketPrice = (age < 18) ? babyTicket : adultTicket;
            Debug.Log("Gia ve: " + ticketPrice);
        }
    }

    // Bài Tập 8: Kiểm Tra Học Sinh Xuất Sắc
    void BaiTap8()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        Console.Write("Nhập số điểm trung bình của học sinh: ");
        float avgExcellentScore;

        if (float.TryParse(Console.ReadLine(), out avgExcellentScore))
        {
            if (avgExcellentScore >= 9f)
            {
                Debug.Log("Hoc sinh xuat sac");
            }
            else Debug.Log("");

            // Kiểm tra xem học sinh có đạt danh hiệu xuất sắc không (điểm trung bình >= 9.0)
        }
    }
        //Bài Tập 9: So Sánh Ba Số
        void BaiTap9()
        {
            // Nhập ba số nguyên từ bàn phím
            Console.Write("Nhập số thứ nhất ");
            int number1;
            Console.Write("Nhập số thứ hai ");
            int number2;
            Console.Write("Nhap so thu 3");
            int number3;

            // Kiểm tra và in ra số lớn nhất trong ba số đó
            if (int.TryParse(Console.ReadLine(), out number1) && (int.TryParse(Console.ReadLine(), out number2) && (int.TryParse(Console.ReadLine(), out number3))))
            {
                int maxNumber = Mathf.Max(number1, Mathf.Max(number2, number3));
                Debug.Log("So lon nhat la: " + maxNumber);

            }
        }

        // Bài Tập 10: Tính Tiền Lương
        void BaiTap10()
        {
            float hourlyWage = 25.5f;
            float overtime = 1.5f;
            double salary = 0;
            Console.Write("Nhap so gio lam: ");
            double timeWork;
            // Nhập số giờ làm việc và mức lương cố định từ bàn phím
            // Nếu nhân viên làm trên 40 giờ, lương được tính thêm giờ
            // Nếu làm dưới hoặc bằng 40 giờ, lương tính theo giờ cố định
            if (double.TryParse(Console.ReadLine(), out timeWork))
            {
                if (timeWork > 40)
                {
                    double overtimeHours = timeWork - 40;
                    salary = (40 * hourlyWage) + (overtimeHours * hourlyWage * 1.5);
                }
                else
                {
                    salary = timeWork * hourlyWage;
                }
                Debug.Log("Tien luong nhan vien" + salary);
            }
        }

        // Bài Tập 11: Kiểm Tra Điều Kiện Vào Câu Lạc Bộ
        void BaiTap11()
        {
            bool numberClub = true;
            Console.Write("Nhap do dooi");
            int age;

            // Nhập tuổi và kiểm tra xem người đó có thẻ thành viên hay không
            // Kiểm tra nếu trên 18 tuổi và có thẻ thành viên thì được vào câu lạc bộ
            if (int.TryParse(Console.ReadLine(), out age))
            {
                if (age > 18 && numberClub == true)
                {
                    Debug.Log("Duoc vao");
                }
                else Debug.Log("Khong duoc vao");
            }
        }
        // Bài Tập 12: Phân Loại Học Sinh
        void BaiTap12()
        {
        // Nhập điểm trung bình của học sinh từ bàn phím
        Console.Write("Nhap diem trung binh;");
        float avgScrore;
            // Phân loại học sinh theo thang điểm từ xuất sắc đến yếu
         if(float.TryParse(Console.ReadLine(),out avgScrore))
        {
            if (avgScrore > 9f) Debug.Log("Xuat sac");
            else if (avgScrore > 8f) Debug.Log("Gioi");
            else if (avgScrore > 6f) Debug.Log("Trung binh");
            else if (avgScrore > 4f) Debug.Log("Yeu");
            else Debug.Log(" Kem");
        }
        }

        // Bài Tập 13: Tính Tiền Điện
        void BaiTap13()
        {
            // Nhập số điện tiêu thụ từ bàn phím
            double eletricPoint;
            // Tính tiền điện theo công thức: <= 100 kWh: 1,500 đồng/kWh, >100 kWh: 2,000 đồng/kWh
            if (double.TryParse(Console.ReadLine(),out eletricPoint))
            {
                if(eletricPoint <= 100)
                {
                    float eletricMoney = (float)eletricPoint * 1500f;
                    Debug.Log("Tien dien"+ eletricMoney);
                }
                else
                {
                    float eletricMoney = (float)eletricPoint *2000f;
                    Debug.Log("Tien dien"+ eletricMoney);
                }
            }
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
        Console.Write("Nhập thu nhập cá nhân (triệu VND/tháng): ");
        float income;

        // Kiểm tra nhập có hợp lệ không
        if (float.TryParse(Console.ReadLine(), out income) && income >= 0)
        {
            float tax = CalculateTax(income);
            Debug.Log("Thuế thu nhập cá nhân phải nộp: {tax} triệu VND");
        }
        else
        {
            Debug.Log("Vui lòng nhập số thu nhập hợp lệ!");
        }
    }

    float CalculateTax(float income)
    {
        float tax = 0;

        if (income <= 5)
            tax = income * 0.05f;
        else if (income <= 10)
            tax = (5 * 0.05f) + ((income - 5) * 0.1f);
        else if (income <= 20)
            tax = (5 * 0.05f) + (5 * 0.1f) + ((income - 10) * 0.15f);
        else if (income <= 30)
            tax = (5 * 0.05f) + (5 * 0.1f) + (10 * 0.15f) + ((income - 20) * 0.2f);
        else
            tax = (5 * 0.05f) + (5 * 0.1f) + (10 * 0.15f) + (10 * 0.2f) + ((income - 30) * 0.25f);

        return tax;
    }

        

        // Bài Tập 17: Tính Điểm Trung Bình Của Môn Học
        void BaiTap17()
        {
        // Nhập điểm của 3 bài kiểm tra từ bàn phím
        float math;
        float art;
        float english;
        if (float.TryParse(Console.ReadLine(), out math) && float.TryParse(Console.ReadLine(), out english) && float.TryParse(Console.ReadLine(), out art))
        {
            float avg3 = (math + art + english) / 3;
            // Tính điểm trung bình và kiểm tra xem học sinh có đạt yêu cầu hay không (>= 5.0)
            if(avg3 >= 5.0f)
            {
                Debug.Log("Dat");
            }
            Debug.Log("Khong dat");
        }


    }

    // Bài Tập 18: Kiểm Tra Điều Kiện Nhập Hàng
    void BaiTap18()
    {
        Console.Write("Nhap so hang");
        int stock;

        // Nhập số lượng hàng hiện tại và kiểm tra khả năng nhập thêm hàng (dưới 100 và còn chỗ)
        if (int.TryParse(Console.ReadLine(), out stock))
        {
            if (stock < 100)
            {
                int maxAdd = 100 - stock;
                Debug.Log("Nhap them " + maxAdd);
            }
            Debug.Log("Qua tai khong nhap duoc them");
        }
    }
        // Bài Tập 19: Tìm Số Lớn Hơn 10
        void BaiTap19()
        {
            // Nhập một số từ bàn phím
            Console.Write("nhap so");
            int numTest;
            // Kiểm tra xem số đó có lớn hơn 10 hay không
            if (int.TryParse(Console.ReadLine(), out numTest))
            {
                if (numTest > 10) Debug.Log("So lon hon 10");
                Debug.Log("So nho hon 10");
            }
        }

        // Bài Tập 20: Kiểm Tra Điều Kiện Đăng Ký Khóa Học
        void BaiTap20()
        {
            // Nhập điểm tổng kết và các điều kiện khác từ bàn phím
            // Kiểm tra xem học sinh có đủ điều kiện đăng ký khóa học nâng cao không
        }
    
}
