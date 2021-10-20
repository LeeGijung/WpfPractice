# WPF 연습

## 00. 참고

* 레이아웃
   * StackPanel
      * 다수의 컨트롤을 쌓아서 표시하는 레이아웃
   * Panel
   * Canvas
      * ex) canvas.Top / canvas.Left ...
   * DockPanel
      * ex) DockPanel.Dock="Left" / "Right" / "Top" ...
   * WrapPanel
   * UniformGrid
      * UI의 행과 열에 출력 내용을 자동으로 처리
   * Grid
* 컨트롤
    * TextBlock
    * TextBox
    * ProgressBar
    * Slider
    * Password
    * Image
        * 그림 표시
    * MediaElement
        * 동영상 표시
* 컨텐츠 컨트롤 (Contents 속성을 갖는 컨트롤)
   * Button
   * Border
   * Scrollviewer
   * ViewBox
   * Frame
      *  탐색(Navigation)을 지원
* 사용자 정의 컨트롤
   * Page 
      * Window창과 비슷
* 라이브러리
   * NavigationService
      * Page에서 URI의 객체를 탐색
      * ex) NavigationService.Navigate(new Uri("/Pages/Contact.xaml", UriKind.Relative));

## 01. WPF Application 생성

### [WpfBasicControlApp]

![WpfBasicControlApp](https://user-images.githubusercontent.com/23272977/137762748-e28d6ef6-1481-45e8-a9c5-a96b7b7c995c.png)

StackPanel 레이아웃 내 TextBlock, TextBox, ProgressBar, Slider, PasswordBox 컨트롤 추가 연습

### [WpfMultiMediaControlApp]

![WpfMultiMediaControlApp](https://user-images.githubusercontent.com/23272977/137762780-e5824981-7a94-4730-b6b8-f55a96eba3a0.png)

Grid 내 Image, MediaElement 컨트롤 추가 연습
(MediaElement 컨트롤로 그냥 동영상을 띄워서는 안나오는 듯 하다)

### [WpfContentsControlApp]

![image](https://user-images.githubusercontent.com/23272977/137766196-7edcfa2a-02fa-482f-b408-1645538366f4.png)

StackPanel 내 컨텐츠 컨트롤 추가 연습

### [WpfNavigationApp]

![image](https://user-images.githubusercontent.com/23272977/137769817-338c9b70-5be5-4102-acea-163bb427ed6c.png)

Page, Frame 컨트롤, Hyperlink를 통한 페이지 이동 처리 연습

### [Exercise_1]

![image](https://user-images.githubusercontent.com/23272977/137773345-b542e187-80e9-4fc0-9292-2d1952f5ccdc.png)

Page와 TexBox, TextBlock, Frame 컨트롤을 이용하여 데이터 입력창 생성 연습

### [WpfXamlApp]

Xaml의 이해와 객체 생성, 속성 부여, 이벤트 처리 연습

### [Exercise_2]

![image](https://user-images.githubusercontent.com/23272977/138123095-f5120375-ece9-4020-bac5-dc9d0878414b.png)

Page와 Button, TextBlock, Navigation을 이용하여 버튼 클릭시 Page 이동 처리 연습

### [Exercise_3]

![image](https://user-images.githubusercontent.com/23272977/138127324-65425d01-604f-400d-b836-84b57bc2d5b6.png)

Page, ListBox, Button을 이용하여 토론 페이지 생성 처리 연습

