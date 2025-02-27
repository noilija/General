class Task
{
    // this value should be shared between all instances of Task
    // unfortunately it is not shared between all instances of Task
    // i will try to fix it
    static sharedValue = 0; // Initialize static sharedValue
    constructor(id,zadatak)
    {
        this.id=id;
        this.zadatak=zadatak;
        this.subTasks=[];
        // Remove this.sharedValue initialization
    }
    toString()
    {
       return this.id+" "+ this.zadatak;
    }

    printTask()
    {
       console.log(this.id+" "+this.zadatak);
    }
    addSubTask(tmpTask)
    {
        let novi= new Task();
        Task.sharedValue++; // Increment static sharedValue
        novi.id=Task.sharedValue;
        novi.zadatak=tmpTask.zadatak;
        this.subTasks.push(novi);
    }
    
    addSubTask2(tekst)
    {
        try
        {
            let novi= new Task();
            novi.id=Task.sharedValue+1;
            novi.zadatak=tekst;
            Task.sharedValue++; // Increment static sharedValue
            this.subTasks.push(novi);
        }
        catch(error)
        {
            if(error instanceof TypeError)
                console.log("Greska u subtask2");
            else
                console.log("Wtf greska ");
            // Handle error
        }
    }
    printSubTasks(task,indent=0)
    {
        let indentation = ' '.repeat(indent); // Dodavanje razmaka za uvlaku
        console.log(`${indentation}${task}`);
        //task.printTask();
        if(task.subTasks && this.subTasks.length>0)
        {
            task.subTasks.forEach(sub => {
                sub.printSubTasks(sub,indent+2);
            });  
        }
    }
    findTask2(number,task)
    {
        task.subTasks.forEach(element => {
            if(element.id===number)
                return element;
            else
            if(element.subTasks.length===0)
                return null;
            else
                return this.findTask(number,task.subTasks);
        });
    }
    findTask(number) {
        // Prolazimo kroz sve podzadatke
        for (let element of this.subTasks) {
            if (element.id === number) {
                return element; // Pronašli smo odgovarajući task
            }
            // Rekurzivno tražimo u podzadatcima
            let foundTask = element.findTask(number);
            if (foundTask) {
                return foundTask; // Ako je pronađen u podzadacima, vraćamo ga
            }
        }
        return null; // Ako nema rezultata, vraćamo null
    }
}
export default Task;