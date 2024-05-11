using ShapeAreaLibrary; // ���������� � ��������

[TestFixture] // �������, ������������, ��� ��� ����� � �������
public class UnitTests
{
    //���� ���������� ������� �����
    [Test]
    public void CircleArea()
    {
        var circle = new Circle(5); // �������� ����� � �������� 5
        Assert.AreEqual(Math.PI * 25, circle.CalculateArea()); // �������� ������������ ����������� �������, ����� - ����� �� �� ������� ��������
    }

    // ���� ���������� ������� ������������
    [Test]
    public void TriangleArea()
    {
        var triangle = new Triangle(3, 4, 5); // �������� ������������ �� ��������� 3, 4, 5
        Assert.AreEqual(6, triangle.CalculateArea()); // �������� ������������ ����������� ������� - ���������� �����: 6
    }

    // ���� �������� ������������ �� ���������������
    [Test]
    public void TriangleRight()
    {
        var triangle = new Triangle(3, 4, 5); // �������� �������������� ������������ �� ��������� 3, 4, 5
        Assert.IsTrue(triangle.IsRight()); // ��������, ��� ����������� �������������
    }
}
