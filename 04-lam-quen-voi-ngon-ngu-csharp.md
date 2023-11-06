(content TBU)

### I. Nhập xuất và kiểu dữ liệu cơ bản

**1. Viết chương trình nhập vào tên và xuất ra "Hello, " [tên]**
  - sử dụng `Console.WriteLine()` để xuất và `Console.ReadLine()` để đọc

**2. Viết chương trình nhập vào 1 số và xuất ra bình phương của số đó**
  - đổi từ chuỗi sang số dùng `int.Parse("string")`
  - dùng `Math.Pow` để lấy bình phương
  
**3. Viết chương trình nhập vào 2 số, tính tổng 2 số đó**
  - dùng `int.Parse` để đổi từ chuỗi sang số và cộng 2 số lại
  
**4. Viết chương trình nhập vào 1 ký tự bất kỳ, in ra "Bạn đã nhập số" nếu ký tự đó là số, "Bạn đã nhập chuỗi" nếu ký tự không phải là số**
  - dùng `int.TryParse` để kiểm tra 1 chuỗi có phải là số hay không. 

**5. Viết chương trình nhập vào năm sinh, in ra số tuổi**
  - Tuổi = năm hiện tại - năm sinh  
  - Ngày hiện tại = `DateTime.Now`
   
### II. Câu điều kiện if else, for/foreach, while/do..while

**6. Viết chương trình nhập vào 1 ký tự bất kỳ, lặp lại đến khi nào người dùng nhập vào 1 số bằng 2 cách:**
  - sử dụng `while`
  - sử dụng `do..while`
  
**7. Viết chương trình nhập vào 1 số từ 2 tới 8, xuất ra "Monday" nếu số nhập vào là 2, "Tuesday" nếu số 3, ...**
  - Lặp lại cho tới khi nhập đúng số từ 2 tới 8 (ví dụ nếu người dùng nhập 0 thì báo nhập lại)
  - Sử dụng `if else` để xuất kết quả
  
**8. Tương tự như bài 7 nhưng sử dụng switch case**

**9. Tương tự bài 7 nhưng sử dụng pattern matching**

```cs
  var day = switch input
  {
     2 => "Monday",
	 3 => "Tuesday",
	 ...
  }
```

**10. Viết chương trình nhập vào 1 số, tính tổng các số liên tiếp từ 0.**
  - Ví dụ nhập vào 5 => xuất ra tổng 1 + 2 + 3 + 4 + 5
  - Lặp lại bước nhập số nếu người dùng nhập ký tự không phải là số

