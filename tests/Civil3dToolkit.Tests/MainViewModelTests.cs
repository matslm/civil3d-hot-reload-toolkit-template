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
        Mock<IUserMessageService> mockMessageService = new();
        
        // Set up the mock to return false (failure)
        mockCivilService
            .Setup(s => s.DrawSquare(It.IsAny<double>(), It.IsAny<double>(), It.IsAny<double>()))
            .Returns(false);

        MainViewModel viewModel = new(mockCivilService.Object, mockMessageService.Object);

        // Act
        viewModel.ExecuteSampleActionCommand.Execute(null);

        // Assert
        Assert.Equal("Failed to draw the square. Check AutoCAD console.", viewModel.GreetingMessage);
        
        // Verify that the civil service was indeed called
        mockCivilService.Verify(s => s.DrawSquare(100.0, 100.0, 5.0), Times.Once);

        // Verify that the error message was shown
        mockMessageService.Verify(m => m.ShowError(It.IsAny<string>(), It.IsAny<string>(), null), Times.Once);
    }

    [Fact]
    public void ExecuteSampleActionWhenCivilServiceSucceedsShouldUpdateGreetingMessage()
    {
        // Arrange
        Mock<ICivilService> mockCivilService = new();
        Mock<IUserMessageService> mockMessageService = new();
        
        // Set up the mock to return true (success)
        mockCivilService
            .Setup(s => s.DrawSquare(It.IsAny<double>(), It.IsAny<double>(), It.IsAny<double>()))
            .Returns(true);

        MainViewModel viewModel = new(mockCivilService.Object, mockMessageService.Object);

        // Act
        viewModel.ExecuteSampleActionCommand.Execute(null);

        // Assert
        Assert.Contains("Sample square successfully drawn", viewModel.GreetingMessage);
        
        // Verify success message was shown
        mockMessageService.Verify(m => m.ShowInfo(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
    }
}
