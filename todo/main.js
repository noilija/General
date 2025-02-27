import Task from "./task.js";
import Menu from "./menu.js";


// todo lista je zapravo task
const todo = new Task(0,"ToDo lista");
const meni = new Menu();



let opcijaBroj;
let idTaska;
let tekst;
let currTask;
do
{
    // ovde stampamo meni koji je u klasi Menu
    meni.printMenu();
    tekst=prompt("Enter menu option number: ");
    opcijaBroj=parseInt(tekst);
    console.log(opcijaBroj);
    // 1 Show todo
    if(opcijaBroj===1)
    {
        todo.printSubTasks(todo,0);
    }
    // 2 Add task
    else if(opcijaBroj===2)
    {
        tekst=prompt("Enter task name: ");

        currTask= new Task(0,tekst);
        currTask.printTask();
        todo.addSubTask(currTask);
        console.log("Your ToDo List after update:");
        todo.printSubTasks(todo,0);
    }
    // 3 Add subTask
    else if(opcijaBroj==3)
    {
        // Entering id of task that will get subtask
        tekst=prompt("Choose id of task: ");
        idTaska=parseInt(tekst);
        let trenutniFindObj=todo.findTask(idTaska);
        // checking if id of task exists
        if(trenutniFindObj===null)
            console.log("Ne postoji ovaj id");
        else
        {
            console.log("/t pronadjeni objekat: "+ trenutniFindObj.id);
            tekst=prompt("Enter subTask name: ");
            trenutniFindObj.addSubTask2(tekst);
            console.log("Your ToDo List after update:");
            todo.printSubTasks(todo,0);
        }

    }
    
}while(opcijaBroj!=5); // Option 5 is exit

