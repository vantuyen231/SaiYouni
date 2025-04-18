using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class RecursionPractice : MonoBehaviour
{
    // Start is called before the first frame update
    //Bai 1 --------------
    // Nhập số nguyên dương n từ bàn phím
    [SerializeField] protected int bai1 = 5;

    //Bai 2 --------------
    // Nhập số nguyên dương n từ bàn phím
    [SerializeField] protected int bai2 = 5;


    //Bai 3 --------------
    // Nhập số nguyên n từ bàn phím
    [SerializeField] protected int bai3 = 6;


    //Bai 4 --------------
    // Nhập số nguyên n từ bàn phím
    [SerializeField] protected int bai4 = 5;


    //Bai 5 --------------
    // Nhập hai số nguyên a và b từ bàn phím
    [SerializeField] protected int soA = 36;
    [SerializeField] protected int soB = 60;


    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        this.Bai1Debug(); // Tính giai thừa của một số
        this.Bai2Debug(); // Tính tổng các số từ 1 đến n
        this.Bai3Debug(); // Chuỗi Fibonacci
        this.Bai4Debug(); // Đếm ngược từ n về 1
        this.Bai5Debug(); // Tìm UCLN của hai số
    }

    // Bài Tập 1: Tính Giai Thừa Của Một Số
    protected virtual int BaiTap1(int bai1)
    {
        // Viết hàm đệ quy để tính giai thừa của n
        if (bai1 == 0)
            return 1;
        return bai1 * BaiTap1(bai1 - 1);
    }

    protected virtual void Bai1Debug()
    {
        int result = BaiTap1(bai1);
        Debug.Log("Bài 1 - Giai thừa của " + bai1 + ": " + result);
    }


    // Bài Tập 2: Tính Tổng Các Số Từ 1 Đến N
    protected virtual int BaiTap2(int bai2)
    {
        // Viết hàm đệ quy để tính tổng các số từ 1 đến n
        if (bai2 == 1)
            return 1;
        return bai2 + BaiTap2(bai2 - 1);
    }
    protected virtual void Bai2Debug()
    {
    int result = BaiTap2(bai2);
        Debug.Log("Bài 1 - Giai thừa của " + bai2 + ": " + result);
    }

    // Bài Tập 3: Chuỗi Fibonacci
    protected virtual int BaiTap3(int bai3)
    {
        // Viết hàm đệ quy để tính số Fibonacci thứ n
        if (bai3 == 0)
            return 0;
        if (bai3 == 1)
            return 1;
        return BaiTap3(bai3 - 1) + BaiTap3(bai3 - 2);
    }

    protected virtual void Bai3Debug()
    {
        int result = BaiTap3(bai3);
        Debug.Log("Bài 3 - Số Fibonacci thứ " + bai3 + ": " + result);
    }

    // Bài Tập 4: Đếm Ngược
    protected virtual void BaiTap4(int bai4)
    {
        // Viết hàm đệ quy để đếm ngược từ n về 1
        if (bai4 == 0) return;

        Debug.Log("Dem nguoc bai4: " + bai4);
        BaiTap4(bai4 - 1);
    }

    protected virtual void Bai4Debug()
    {
        Debug.Log("Bài 4 - Đếm ngược từ " + bai4 + ":");
        BaiTap4(bai4);
    }


    // Bài Tập 5: Tìm UCLN (Ước Chung Lớn Nhất)
    protected virtual int BaiTap5(int soA, int soB)
    {
        // Viết hàm đệ quy để tìm UCLN của hai số theo thuật toán Euclid
        if (soB == 0)
            return soA;
        return BaiTap5(soB, soA % soB);
    }

    protected virtual void Bai5Debug()
    {
        int result = BaiTap5(soA, soB);
        Debug.Log("Bài 5 - UCLN của " + soA + " và " + soB + " la : " + result);
    }
}
