    function getQueryParam(param) {
      let urlParams = new URLSearchParams(window.location.search);
      return urlParams.get(param);
    }

    // Load event details on page load
    function loadEventDetails() {
      let eventId = getQueryParam("id");
      let events = JSON.parse(localStorage.getItem("events")) || [];

      // Find the event with matching id
      let event = null;
      for (let i = 0; i < events.length; i++) {
        if (events[i].id == eventId) {
          event = events[i];
          break;
        }
      }

      if (event) {
        document.getElementById("eventId").innerHTML = "<strong>ID:</strong> " + event.id;
        document.getElementById("eventName").innerHTML = "<strong>Name:</strong> " + event.name;
        document.getElementById("eventCategory").innerHTML = "<strong>Category:</strong> " + event.category;
        document.getElementById("eventDate").innerHTML = "<strong>Date:</strong> " + event.date;
        document.getElementById("eventTime").innerHTML = "<strong>Time:</strong> " + event.time;
      } else {
        document.getElementById("eventDetailsBox").innerHTML = "<p class='text-danger'>Event not found!</p>";
      }
    }

    // Handle register button click
    function registerParticipant() {
      let firstName = document.getElementById("firstName").value.trim();
      let lastName = document.getElementById("lastName").value.trim();
      let email = document.getElementById("email").value.trim();

      // Simple validation
      if (!firstName || !lastName || !email) {
        alert("Please fill in all fields!");
        return;
      }

      // Check email format (basic check)
      if (!email.includes("@")) {
        alert("Please enter a valid email!");
        return;
      }

      alert("You are successfully registered to this event!");
      document.getElementById("firstName").value="";
      document.getElementById("lastName").value="";
      document.getElementById("email").value="";
    }

    window.onload = loadEventDetails;