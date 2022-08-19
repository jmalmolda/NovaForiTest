import { FC, useState } from "react"
import { createNewTask } from "../../api/toDoTasks"

const NewTaskForm: FC = () => {
    const [description, setDescription] = useState<string>('')

    return (
        <div id="newtask">
            <input 
                value={description} 
                onChange={
                    (event) => setDescription(event.target.value)
                } 
                type="text" 
                placeholder="Add a new Task"/>
            <button 
                id="push" 
                onClick={
                    async () => {
                        await createNewTask(description)
                    }
                }>
                    Add
            </button>
        </div>   
    )
}

export default NewTaskForm