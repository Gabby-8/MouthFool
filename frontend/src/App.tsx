import { useEffect, useState } from "react";

function App() {
  const [message, setMessage] = useState ("");

    useEffect(() => {
      fetch("https://localhost:5125/api/home")
        .then(res => res.json())
        .then(data => setMessage(data.message))
        .catch(err => console.error(err));
    }, []);

    return (
      <div style={{ padding: "2rem" }}>
        <h1>React + .Net App</h1>
        <p>{message}</p>
      </div>
    );
}

export default App;