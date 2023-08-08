using SingletoneDesignPattern;

Console.WriteLine("Hello, World! This is Arezo's singletone example.");
ApplicationGeneralReport.Instance.TodayViews = 1000;
ApplicationGeneralReport.Instance.OnlineUsers = 100;

Console.WriteLine($"TodayViews: {ApplicationGeneralReport.Instance.TodayViews}");
Console.WriteLine($"TodayViews: {ApplicationGeneralReport.Instance.OnlineUsers}");

