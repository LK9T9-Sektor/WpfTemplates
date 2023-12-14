using System.Windows;

namespace WpfTemplates.Views;

public partial class GroupBoxCollection : Window
{
    public IEnumerable<DVRCameraState> Cameras { get; }

    public GroupBoxCollection()
    {
        InitializeComponent();
        DataContext = this;

        Cameras = new List<DVRCameraState>()
            {
                new DVRCameraState()
                {
                    Cars = new List<CarTest>()
                    {
                        new CarTest() { Name = "AB1010"},
                        new CarTest() { Name = "AB2222"},
                        new CarTest() { Name = "AB3333"},
                        new CarTest() { Name = "AB4444"},
                        new CarTest() { Name = "AB5555"},
                        new CarTest() { Name = "AB6666"}
                    },
                    Camera = new DVRCamera("Камера 1", "127.0.0.1", "8080", "admin", "123"),
                    Message = "Подключена"
                },
                new DVRCameraState()
                {
                    Cars = new List<CarTest>() {
                        new CarTest() { Name = "AB1010"},
                        new CarTest() { Name = "AB1010"},
                        new CarTest() { Name = "AB1010"},
                        new CarTest() { Name = "AB1010"}
                    },
                    Camera = new DVRCamera("Камера 2", "127.0.0.2", "8080", "admin", "123")
                },
                new DVRCameraState()
                {
                    Cars = new List<CarTest>() {
                        new CarTest() { Name = "AB1010"},
                        new CarTest() { Name = "AB1010"},
                        new CarTest() { Name = "AB1010"}
                    },
                    Camera = new DVRCamera("Камера 3", "127.0.0.3", "8080", "admin", "123")
                },
                new DVRCameraState()
                {
                    Cars = new List<CarTest>() {
                        new CarTest() { Name = "AB1010"},
                        new CarTest() { Name = "AB1010"}
                    },
                    Camera = new DVRCamera("Камера 4", "127.0.0.4", "8080", "admin", "123")
                },
                new DVRCameraState()
                {
                    Cars = new List<CarTest>()
                    {
                        new CarTest() { Name = "AB1010"}
                    },
                    Camera = new DVRCamera("Камера 5", "127.0.0.5", "8080", "admin", "123")
                },
                new DVRCameraState()
                {
                    Cars = new List<CarTest>()
                    {
                        new CarTest() { Name = "AB1010"}
                    },
                    Camera = new DVRCamera("Камера 6", "127.0.0.6", "8080", "admin", "123")
                },
            };

        //HahaList = new List<DVRCameraState>()
        //{
        //    new DVRCameraState(new List<CarTest>()
        //        {
        //            new CarTest() { Name = "Car1" },
        //            new CarTest() { Name = "Car2" },
        //            new CarTest() { Name = "Car3" }
        //        })
        //    {
        //        UserId = 1,
        //        Camera = new DVRCamera("01", "127.0.0.1", "8080", "admin", "123")
        //    },
        //    new DVRCameraState(new List<CarTest>()
        //        {
        //            new CarTest() { Name = "Car1" },
        //            new CarTest() { Name = "Car2" },
        //            new CarTest() { Name = "Car3" }
        //        })
        //    {
        //        UserId = 2,
        //        Camera = new DVRCamera("02", "127.0.0.2", "8080", "admin", "123")
        //    },
        //};
    }

}

public class DVRCameraTest : BaseDVRState
{
    public DVRCamera Camera { get; set; }

    public IEnumerable<Car> Cars { get; set; }

    //public DVRCameraTest(IEnumerable<Car> list)
    //{
    //    ItemList = list;
    //}

}

public class Car
{
    public string Name { get; set; }

    //public Car(string name)
    //{
    //    Name = name;
    //}
}

public class BaseDVRState
{
    public uint? ErrorCode { get; private set; }
    public string? Message { get; set; }
    public bool Success => ErrorCode == null;

    public void AddError(string? message, uint? errorCode = null)
    {
        ErrorCode = errorCode;
        Message = message ?? "[Ошибка без описания]";
    }

    public void SetSuccess(string? message)
    {
        ErrorCode = null;
        Message = message ?? "[Статус без описания]";
    }

}

public record DVRCamera(string Name,
    string DVRIPAddress,
    string DVRPortNumber,
    string DVRUserName,
    string DVRPassword);

public class DVRCameraState : BaseDVRState
{
    public DVRCamera Camera { get; set; }
    public int UserId { get; set; }

    public bool IsCameraOnArm(int[] alarmHandle, int userId)
    {
        return alarmHandle[userId] >= 0;
    }

    public bool IsUserLoggedIn(int userId)
    {
        UserId = userId;

        return UserId >= 0;
    }

    //public CarCaptureInfo Car = new();

    public IEnumerable<CarTest> Cars { get; set; } = new List<CarTest>();

}

public class CarTest
{
    public int Id { get; set; }
    public string Name { get; set; }
}

