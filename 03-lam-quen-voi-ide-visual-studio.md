# Làm quen với Visual Studio | Trở thành .NET Developer - từ 0 tới hero | 03

Visual Studio (VS) là IDE mạnh mẽ và phổ biến cho những LTV (Lập trình viên) .NET. Tuy bạn có thể sử dụng nhiều phần mềm khác nhau (VSCode/Rider), hoặc thậm chí kết hợp giữa CLI và bất kể chương trình nào có thể soạn thảo code được, nhưng VS vẫn luôn là lựa chọn hàng đầu của nhiều người bởi sự miễn phí và những tính năng mà nó mang lại.

> Nếu làm việc cá nhân thì bạn nên sử dụng phiên bản Community, là phiên bản miễn phí của VS

### Khởi động

Sau khi cài đặt, tùy vào tùy chỉnh và phiên bản, có thể bạn sẽ thấy cửa sổ Start Windows hoặc vào trực tiếp VS:

**Start windows**: bên trái là các projects (dự án) gần đây, bên phải là các shortcut chức năng
![start windows](img/03/03-vs-start-windows.png)

hoặc sẽ thấy **Visual Studio** blank
![VS blank](img/03/03-vs-blank.png)

### Tạo project

Để tạo project, bạn vào `File > New > Project`

![new project](img/03/03-new-project.png)

Ở đây bạn sẽ thấy các templates (mẫu dự án) bạn sử dụng gần đây phía bên trái (1), hoặc chọn những templates hỗ trợ phía bên phải. Lưu ý chọn đúng ngôn ngữ (C#) cho project của bạn (2).

![project template](img/03/03-project-template.png)

Chọn tên cho project và nơi lưu trữ:

![configure project](img/03/03-configure-project.png)

1 vài lưu ý:
- Nên đặt tên project theo cú pháp PascalCase (viết hoa các chữ đầu), và không dùng khoảng trắng (vẫn hợp lệ nhưng nên tránh). Ví dụ:
  - `MyProject` :white_check_mark:
  - `ProductManagement` :white_check_mark:
  - `Product management` :x: sử dụng khoảng trắng
  - `productmanagement` :x: không viết hoa
- Nên chọn "Location" không quá sâu, đường dẫn quá dài sẽ gây lỗi khi mở project.
  - Bạn có thể tùy chọn Location mặc định sau ở menu `Tools > Options > Projects and Solutions > Locations`

Sau khi next, bạn chọn framework cho project. Nếu chưa biết về chỗ này, VS sẽ chọn version stable (ổn định) mới nhất được cài đặt trong máy của bạn.

![Alt text](img/03/03-select-framework.png)

Sau khi thành công, bạn có thể bắt đầu viết và chạy chương trình của mình. Để chạy, bấm `F5` hoặc `Debug > Start Debugging`

![Alt text](img/03/03-start-debugging.png)

### Các Views thông dụng

Views (đôi khi gọi là windows cũng được) là các tab hiển thị các chức năng tương ứng trong VS. Hầu hết các View đều nằm ở menu `View`. `Solution Explorer` là 1 trong nữa view được sử dụng nhiều nhất.

![view](img/03/03-window-views.png)

> Bạn nên nhớ phím tắt của các view thông dụng để dễ dàng mở khi cần

Xem gif dưới đây để biết các thao tác thông thường với view (pin/unpin, snap, resize), tuy nhiên những thao tác này mình rất ít khi sử dụng:

![view action](img/03/03-vs-view-action.gif)

Ngoài ra, đôi khi bạn không tìm thấy view (hoặc bất cứ gì), bạn có thể dùng chức năng tìm kiếm:

![search](img/03/03-vs-search.png)

### Context menu

> Từ giờ những từ tiếng anh kiểu thế này mình sẽ không dịch nữa, các bạn tự google hen

Context menu sẽ tùy thuộc vào context (nơi bạn bấm chuột phải), sẽ có 3 nơi bạn cần để ý:

**1. Editor context**

Editor context menu chứa những action liên quan tới file bạn đang mở, đôi khi là đoạn code bạn đang highlight.

![Editor context](img/03/03-editor-context.png)

**2. Project context**

Là menu chứa những action liên quan tới project, như build project (`Build`), thêm mới file vào project (`Add > New Item...`) hoặc chạy ở chế độ debug (`Debug`)

![Project context](img/03/03-project-context.png)

> Lưu ý là right-click vào project name để mở project context menu

**3. Solution context**

Solution có thể chứa nhiều project, ở đây bạn có thể thêm mới project vào solution (`Add > New Project...`), build tất cả projects có trong Solution (`Build Solution`) hoặc thêm những thư viện bên ngoài vào projects (`Manage NuGet Packges for Solution...`)

![Solution context](img/03/03-solution-context.png)

### Các commands thông dụng

**Code search** <kbd>Ctrl</kbd> <kbd>,</kbd> (hoặc <kbd>Ctrl</kbd> <kbd>T</kbd>) là command có thể được xem là sử dụng nhiều nhất. Goto (code search) giúp bạn nhảy đến file/hàm 1 cách nhanh nhất.

![goto](img/03/03-goto.png)

**Go To Definition** <kbd>F12</kbd> đi tới nơi định nghĩa của đối tượng đang được chọn (không cần highlight). Trong ví dụ này, khi <kbd>F12</kbd> sẽ nhảy tới chỗ khai báo thuộc tính `Name`. Tương tự thì 2 chức năng bên dưới như tên gọi của nó.

![goto command](img/03/03-goto-command.png)

**Debug** <kbd>F5</kbd> chạy project dưới dạng debug. Có 3 cách để run debug:

1. Qua menu `Debug > Start Debugging`
2. Qua debug button trên menu
3. Qua project context menu `Debug > Start New Instance`

![Debug](img/03/03-debug.png)

**Build** <kbd>F6</kbd> build code để phát hiện lỗi biên dịch và chuẩn bị debug.

> Run debug cũng sẽ tự động build project

**Navigate** <kbd>Ctrl</kbd> <kbd>-</kbd> **Backward**, <kbd>Ctrl</kbd> <kbd>Shift</kbd> <kbd>-</kbd> **Forward** quay lại vị trí trước đó của con trỏ. Đây là 2 commands khá hữu ích khi làm việc với những file code dài.

![Navigate](img/03/03-navigate-code.png)

**Commment và bookmark**, bookmark giúp bạn đánh dấu những đoạn code cần quay lại thường xuyên

![Comment and bookmark](img/03/03-comment-and-bookmark.png)

**Format document** <kbd>Ctrl</kbd> <kbd>E</kbd> + <kbd>Ctrl</kbd> <kbd>D</kbd> là command vô cùng hữu dụng để format lại code (canh hàng, canh dấu, xóa whitespaces...). Để bấm phía tắt, giữ phím <kbd>Ctrl</kbd> sau đó bấm <kbd>E</kbd> và <kbd>D</kbd>. Ngoài ra có có icon hình cái chổi phía dưới cũng có thể format được code.

![format document](img/03/03-format-document.png)

:white_check_mark: Excercies: làm quen với phím tắt và cách hoạt động của nó

Clone repo https://github.com/oclockvn/megax
  - dùng chức năng *Code search* để tìm hàm `RequestLeaveAsync`, sau đó tìm những nơi sử dụng hàm đó (*Find all references*)
  - Đi tới file `AuthController.cs`, sau đó dùng chức năng *Go to definition* và *Go to implementation* cho chỗ gọi hàm `userService.CreateUserAsync`. Phân biệt điểm khác biệt của 2 chức năng.
  - Dùng thử các chức năng comment, bookmark và format document
