        const btn=document.getElementById("toggleBtn");
        // Load saved theme
        if(localStorage.getItem("theme")==="dark"){
            document.body.classList.add("dark");

        }
        btn.addEventListener("click",function(){
        document.body.classList.toggle("dark");
        
        // save theme
        if(document.body.classList.contains("dark")){
            localStorage.setItem("theme","dark");
        }
        else{
        localStorage.setItem("theme","light");
        }
        });