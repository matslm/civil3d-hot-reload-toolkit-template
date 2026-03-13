namespace Civil3dToolkit.Tests;

using Xunit;
using Moq;
using Civil3dToolkit.Core.Interfaces;
using Civil3dToolkit.Core.ViewModels;

public class MainViewModelTests
{
    [Fact]
    public void ExecuteSampleActionWhenCivilServiceFailsShouldUpdateGreetingMessage()
    {
        // Arrange
        Mock<ICivilService> mockCivilService = new();
        
        // Set up the mock to return false (failure)
        mockCivilService
            .Setup(s => s.DrawSquare(It.IsAny<double>(), It.IsAny<double>(), It.IsAny<double>()))
            .Returns(false);

        MainViewModel viewModel = new(mockCivilService.Object);

        // Act
        viewModel.ExecuteSampleActionCommand.Execute(null);

        // Assert
        Assert.Equal("Failed to draw the square. Check AutoCAD console.", viewModel.GreetingMessage);
        
        // Verify that the civil service was indeed called
        mockCivilService.Verify(s => s.DrawSquare(100.0, 100.0, 5.0), Times.Once);
    }
}
