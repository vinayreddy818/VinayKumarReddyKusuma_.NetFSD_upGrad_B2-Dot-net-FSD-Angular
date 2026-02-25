const list=document.getElementById("tasksList");

document.getElementById("addbtn").addEventListener("click",()=>{
    const li=document.createElement("li");
    const tasks=document.getElementById("task").value;
    li.innerHTML=`${tasks} 
    <button class="complete">Complete </button>
    <button class="delete">Delete</button>
    <span style="color:green"></span> <br><br>`;
    list.appendChild(li);
})

list.addEventListener("click", function(e){
    if(e.target.classList.contains("complete"))
    {
        e.target.parentElement.querySelector("span").innerHTML="✅ Completed"
    }
    if(e.target.classList.contains("delete"))
    {
        e.target.parentElement.remove();
    }
})
