import { FC, useState } from "react"
import { createNewTask } from "../../api/toDoTasks"

interface NewTaskFormProps {
    onNewTask: () => void
}

const NewTaskForm: FC<NewTaskFormProps> = ({onNewTask}) => {
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
                        setDescription('')
                        onNewTask()
                    }
                }>
                    Add
            </button>
        </div>   
    )
}

export default NewTaskForm