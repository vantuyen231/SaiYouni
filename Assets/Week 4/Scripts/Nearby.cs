using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nearby : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Tìm kẻ địch gần nhất
        BaiTap2(); // Tìm vật phẩm gần nhất
    }

    // Bài Tập 1: Tìm Kẻ Địch Gần Nhất
    void BaiTap1()
    {
        // Tạo danh sách các kẻ địch với tọa độ (x, y, z) trong không gian 3D
        // Vị trí của người chơi được cung cấp
        // Sử dụng công thức khoảng cách Euclid hoặc Vector3.Distance() để tính khoảng cách
        // So sánh khoảng cách và tìm kẻ địch gần nhất
        // Trả về thông tin của kẻ địch gần nhất
    }

    // Bài Tập 2: Tìm Vật Phẩm Gần Nhất
    void BaiTap2()
    {
        // Tạo danh sách các vật phẩm với tọa độ (x, y) trong không gian 2D
        // Vị trí của người chơi được cung cấp
        // Tính khoảng cách từ người chơi đến từng vật phẩm
        // So sánh để tìm vật phẩm gần nhất
        // Trả về thông tin của vật phẩm gần nhất
    }
}
