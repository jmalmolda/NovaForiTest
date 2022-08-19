import { FC  } from 'react'
import { ToDoTask } from '../../api/toDoTasks';

interface ToDoListProps {
  taskList: ToDoTask[]
}
  
const ToDoList: FC<ToDoListProps> = ({taskList}) => {
  const pendingTasks = taskList.filter(task => task.state === 'Pending')
  const completedTasks = taskList.filter(task => task.state === 'Completed')
  return (
    <>
      <h2>Pending</h2>
      <TaskList taskList={pendingTasks}/>
      <h2>Completed</h2>
      <TaskList taskList={completedTasks}/>
    </>
    )
}

const TaskList: FC<ToDoListProps> = ({taskList}) => {
  return (
    <div id="tasks">
      {taskList.length > 0 ? taskList.map(task => (
        <div key={task.id} className="task">
          <span id="taskname">
              {task.description}
          </span>
        </div>
      )): (
        <div>no tasks yet</div>
      )}
    </div>
  )
}

export default ToDoList;