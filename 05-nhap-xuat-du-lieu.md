# Nhập xuất dữ liệu | Trở thành .NET Developer - từ 0 tới hero | 04

### Mục tiêu bài học
- [x] Biết cách xuất dữ liệu ra màn hình dòng lệnh (write to console)
- [x] Biết cách lấy thông tin từ dòng lệnh (read from console)
- [x] Biết 1 số toán tử cơ bản với chuỗi string 

### Tạo project

Tạo 1 console project, visual studio (VS) sẽ tạo 1 console app với 1 số dòng code sẵn:

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/f077637d-255f-43a6-9677-ec502787b0ef)

Chạy chương trình <kbd>F5</kbd>, bạn sẽ thấy "Hello World" xuất hiện ở console:

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/67827586-cb37-4a01-9dcd-6fcccdf283fc)

### 1. Xuất ra console

Sửa đoạn code có sẵn thành như sau:

```cs
static void Main(string[] args)
{
    Console.WriteLine("I am Quang");
}
```

Yay! bạn đã in ra console thành công.

#### Giải thích:
- hàm `Console.WriteLine` nhận vào 1 chuỗi string và trả về void, được dùng để xuất thông tin ra console

> [!TIP]
> Rê chuột lên tên hàm để hiển thị mô tả của hàm, các loại tham số truyền vào hàm và kết quả trả về

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/b36722a0-b655-431f-81a8-cc0ba0758e94)

#### Mở rộng
Vậy nếu muốn in ra nhiều dòng thì sao? thì gọi hàm nhiều lần chứ sao :)

```cs
static void Main(string[] args)
{
    Console.WriteLine("I am Quang");
    Console.WriteLine("I love swimming");
}
```

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/555d6615-61ce-45b8-8f98-bdacb998faaf)

Ngoài ra, với tính chất của string là có thể xuống dòng, mình cũng có thể sử dụng 1 lần write với nội dung như sau:

```cs
static void Main(string[] args)
{
    Console.WriteLine("I am Quang\r\nI love swimming");
}
```

Chuỗi `"\r\n"` là ký tự xuống dòng, do đó bạn được kết quả như mong đợi.

> [!TIP]
> Bạn nên sử dụng `Environment.NewLine` để đạt kết quả đúng khi chạy trên cả Windows và Linux do ở Linux thì xuống dòng chỉ là `"\n"`

refactor đoạn code trên:

```cs
static void Main(string[] args)
{
    Console.WriteLine("I am Quang" + Environment.NewLine + "I love swimming"); // cộng chuỗi
}
```

dĩ nhiên kết quả vẫn như mong đợi:

![image](https://github.com/oclockvn/dotnet-dev-0-to-hero-vietnam/assets/3783976/112c4191-e161-47d7-9c12-349e8747551e)

Ở trên mình cũng đã thực hiện 1 toán tử khác của string là cộng (nỗi) chuỗi (concatnate). Ví dụ:

```cs
var s1 = "A" + "B"; // -> "AB"
var s2 = "A " + "B"; // -> "A B"
var s3 = "A" + "B" + "C"; // -> "ABC"
```
