using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForPractise : MonoBehaviour
{
    private int[] nume = { 2, 6, 8, 2, 6, 1, 8, 9, 4, -14, -9, 124, 99 };
    private List<string> strings = new List<string> { "Ark", "Lol","Valorant","Dota","Hello"};
    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // In tất cả các phần tử trong mảng
        BaiTap2(); // Tính tổng các phần tử trong mảng
        BaiTap3(); // Tìm phần tử lớn nhất trong mảng
        BaiTap4(); // Đếm số lượng số chẵn trong mảng
        BaiTap5(); // In tất cả các chuỗi trong danh sách
        BaiTap6(); // Tìm chuỗi dài nhất trong danh sách
        BaiTap7(); // Tính tổng các số lẻ trong mảng
        BaiTap8(); // In các số chẵn trong mảng
        BaiTap9(6); // Kiểm tra sự tồn tại của một phần tử trong mảng
        BaiTap10(); // Đếm số phần tử âm trong mảng
        BaiTap11(); // In các số lớn hơn 10 trong mảng
        BaiTap12(); // Tìm chuỗi có độ dài ngắn nhất trong danh sách
        BaiTap13(); // Nhân đôi tất cả các phần tử trong mảng
        BaiTap14(); // Tìm số lớn thứ hai trong mảng
        BaiTap15(); // Tìm chuỗi bắt đầu bằng chữ cái A
        BaiTap16(); // Kiểm tra danh sách có chứa chuỗi "Hello" không
        BaiTap17(); // In tất cả các phần tử âm trong mảng
        BaiTap18(8); // Đếm số lần xuất hiện của một phần tử trong mảng
        BaiTap19(); // Tạo danh sách mới từ các phần tử lớn hơn 10
        BaiTap20(); // In các chuỗi có độ dài lớn hơn 5 ký tự
    }

    // Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng
    void BaiTap1()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in tất cả các phần tử trong mảng
        foreach (int num in nume)
        {
            Debug.Log(num);
        }

    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tính tổng tất cả các phần tử trong mảng
        int sum = 0;
        foreach (int num in nume)
        {
            sum += num;
        }
        Debug.Log(sum);
    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tìm phần tử lớn nhất trong mảng
        int maxNum = int.MinValue;
        foreach(int num in nume)
        {
            if (maxNum < num)
                maxNum = num;
        }
        Debug.Log("Phan tu lan nhat trong mang: "+ maxNum);
    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để đếm số lượng phần tử chẵn trong mảng
        int evenCount   = 0;
        foreach(int num in nume)
        {
            if(num %2 ==0)
                evenCount++;
        }
        Debug.Log("Chuoi co " + evenCount + " so chan");
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để in tất cả các chuỗi trong danh sách
        foreach(string str in strings)
        {
            Debug.Log(str);
        }
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        // Tạo một danh sách các chuỗi
        string longString = "";
        // Sử dụng foreach để tìm chuỗi dài nhất trong danh sách
        foreach(string str in strings)
        {
            if(str.Length> longString.Length)
            {
                longString = str;
            }
        }
        Debug.Log("Chuoi dai nhat: "+  longString);

    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        // Tạo một mảng số nguyên
        int evenCout1 = 0;
        // Sử dụng foreach để tính tổng tất cả các số lẻ trong mảng
        foreach(int num in nume)
        {
            if(num%2!=0)
            {
                evenCout1 = evenCout1 + num;
            }
        }
        Debug.Log("Tong tat ca cac so le trong mang" + evenCout1 );
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in tất cả các số chẵn trong mảng
        foreach(int num in nume)
        {
            if(num%2==0)
            {
                Debug.Log("So chan: " + num);
            }
        }

    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9(int value)
    {
        // Tạo một mảng số nguyên và một phần tử cần kiểm tra
        bool exists = false;
        // Sử dụng foreach để kiểm tra xem phần tử đó có tồn tại trong mảng không
        foreach (int num in nume)
        {
            if (num == value)
            {
                exists = true;
                Debug.Log(value + " co ton tai");
                break;

            }
        }
        if (!exists) Debug.Log(value + " Khong ton tai");
    }

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    void BaiTap10()
    {
        // Tạo một mảng số nguyên
        int negaCount = 0;
        // Sử dụng foreach để đếm số lượng các phần tử âm trong mảng
        foreach(int num in nume)
        {
            if (num < 0)
            {
                negaCount ++ ;
            }
        }
        Debug.Log("Chuoi co " + negaCount + " so am");
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in các số lớn hơn 10 trong mảng
        foreach(int num in nume)
        {
            if(num > 10)
            {
                Debug.Log(num);
            }
        }
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để tìm chuỗi có độ dài ngắn nhất trong danh sách
        string shortStr = strings[0];
        foreach(string str in strings)
        {
            if (shortStr.Length < str.Length)
                shortStr = str;

        }
        Debug.Log("Chuoi ngan nhat la " + shortStr);
    }

    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    void BaiTap13()
    {
        // Tạo một mảng số nguyên
        List<int> list13 = new List<int>();
        // Sử dụng foreach để nhân đôi tất cả các phần tử trong mảng
        foreach (int num in nume)
        {
             list13.Add(num*2);
        }
        Debug.Log("Danh sach mang nhan doi: "+ string.Join(", ", list13));

    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        // Tạo một mảng số nguyên
        int maxNum = int.MinValue;
        int secondNum = int.MinValue;
        // Sử dụng foreach để tìm phần tử lớn thứ hai trong mảng
        foreach(int num in nume)
        {
            if(num> maxNum)
            {
                secondNum = maxNum;
                maxNum = num;
            }else if(num>secondNum && num != maxNum) secondNum = num;
        }
        Debug.Log("So lon thu 2 " + secondNum);
    }

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để tìm và in các chuỗi bắt đầu bằng chữ cái 'A'
        foreach(string str in strings)
        {
            if (str.StartsWith("A"))
            {
                Debug.Log("Chuoi bat dau bang A "+str);
            }
        }
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không
        foreach (string str in strings)
        {
            if (str.Contains("Hello"))
            {
                Debug.Log("Danh sach co chua chuoi");
            }
        }
    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in ra tất cả các phần tử âm trong mảng
        foreach (int num in nume)
        {
            if (num < 0)
            {
                Debug.Log(num);
            }
        }
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18(int value)
    {
        // Tạo một mảng số nguyên và một phần tử cụ thể
        // Sử dụng foreach để đếm số lần xuất hiện của phần tử cụ thể đó trong mảng
        int count = 0;
        foreach (int num in nume)
        {
            if (num == value)
                count++;
        }
        Debug.Log("Số lần xuất hiện của " + value + ": " + count);
    }

    // Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    void BaiTap19()
    {
        // Tạo một mảng số nguyên
        List<int> even19 = new List<int>();
        // Sử dụng foreach để tạo một danh sách mới chứa các phần tử có giá trị lớn hơn 10 
        foreach (int num in nume)
        {
            if (num > 10)
            {
                even19.Add(num);
            }
        }
        Debug.Log("Danh sach phan tu lon hon 10: "+ string.Join(", ", even19));

    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để in các chuỗi có độ dài lớn hơn 5 ký tự
        foreach (string str in strings)
        {
            if (str.Length > 5)
            {
                Debug.Log("Chuoi dai hon 5 ky tu: " + str);
            }
        }
    }
}
