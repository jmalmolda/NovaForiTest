using Moq;
using todolist.Controllers;
using todolist.Data.Repository;
using todolist.Models;

namespace todolist.tests
{
    public class ToDoTasksControllerTests
    {
        [Fact]
        public async Task Index_GetsListOfTasksFromRepository()
        {
            // Arrange
            var mockRepo = new Mock<IToDoTaskRepository>();
            mockRepo.Setup(repo => repo.GetTasks())
                .ReturnsAsync(GetTestTasks());
            var controller = new ToDoTasksController(mockRepo.Object);

            // Act
            var result = await controller.GetToDoTasks();

            // Assert
            Assert.IsType<List<ToDoTask>>(result.Value);
            Assert.Equal(2, result.Value.Count());
        }

        [Fact]
        public async Task PostToDoTask_CallsCreateTaskRepository()
        {
            // Arrange
            var guid = Guid.NewGuid();
            var inputTask = new ToDoTask()
            {
                Description = "New task",
            };

            var mockRepo = new Mock<IToDoTaskRepository>();
            var controller = new ToDoTasksController(mockRepo.Object);

            // Act
            var result = await controller.PostToDoTask(inputTask);

            // Assert
            mockRepo.Verify(mock => mock.CreateTask(inputTask), Times.Once());
        }

        private List<ToDoTask> GetTestTasks()
        {
            var tasks = new List<ToDoTask>();
            tasks.Add(new ToDoTask()
            {
                Id = Guid.NewGuid(),
                Description = "Pending task",
                State = StateEnum.Pending
            });
            tasks.Add(new ToDoTask()
            {
                Id = Guid.NewGuid(),
                Description = "Completed task",
                State = StateEnum.Completed
            });
            return tasks;
        }
    }
}