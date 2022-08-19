import React, { FC, useEffect, useState } from 'react'
import { fetchAllTasks, ToDoTask } from '../../api/toDoTasks';
import ToDoList from '../ToDoList/ToDoList';

const ToDoScreen: FC = () => {
    const [taskList, setTaskList] = useState<ToDoTask[]>([])

    const loadTasks = async () => {
        const tasks = await fetchAllTasks();
        setTaskList(tasks)
        console.log('results', tasks);
      };

    useEffect(() => {
        loadTasks()
      }, [])    
    return (
        <div className="container">
            <ToDoList taskList={taskList}/>
        </div>
    )
}

export default ToDoScreen