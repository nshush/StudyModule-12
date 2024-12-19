using System;
using System.Collections.Generic;
using System.Threading;

class User
{
    public string Login { get; set; }
    public string Name { get; set; }
    public bool IsPremium { get; set; }
}

class Program
{
    static void ShowAds()
    {
        Console.WriteLine("�������� ��� ����� ���� � ����������� ������ free.games.for.a.fool.com");
        // ��������� �� 1 �
        Thread.Sleep(1000);

        Console.WriteLine("������ �������� �� ������� � �������� ������ ����� � ������.");
        // ��������� �� 2 �
        Thread.Sleep(2000);

        Console.WriteLine("�������� �������-�������� �� ��� ������, ����� �� ������ �������.");
        // ��������� �� 3 �
        Thread.Sleep(3000);
    }

    static void Main(string[] args)
    {
        // �������� ������ �������������
        List<User> users = new List<User>
        {
            new User { Login = "user1", Name = "�������", IsPremium = false },
            new User { Login = "user2", Name = "�����", IsPremium = true },
            new User { Login = "user3", Name = "����", IsPremium = false }
        };

        // ����������� ������������� � ����� �������, ���� �����
        foreach (var user in users)
        {
            Console.WriteLine($"����� ����������, {user.Name}!");

            if (!user.IsPremium)
            {
                ShowAds();
            }
        }
    }
}