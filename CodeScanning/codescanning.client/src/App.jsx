import './App.css'
import React, { useState } from 'react';

const App = () => {
    const [code, setCode] = useState('');
    const [responseCode, setResponseCode] = useState('');


    const handleChange = (event) => {
        setCode(event.target.value);
    };

    const handleSubmit = (event) => {
        event.preventDefault();

        // Send the code to the backend endpoint
        fetch('https://localhost:7016/Backend/process-code', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ code }) // Send the code as JSON
        })
            .then(response => response.text())
            .then(data => {
                console.log('Response from server:', data);
                // You can handle the response from the server here
                setResponseCode(data); // Update state with response code

            })
            .catch(error => {
                console.error('Error:', error);
            });
    };

    return (
        <div>
            <h1>C# Code Input</h1>
            <form onSubmit={handleSubmit}>
                <div>
                    <label htmlFor="codeInput">Enter C# Code:</label>
                    <textarea
                        id="codeInput"
                        value={code}
                        onChange={handleChange}
                        rows={10}
                        cols={50}
                        placeholder="Enter your C# code here..."
                        required
                    />
                </div>
                <button type="submit">Submit</button>
            </form>
            {responseCode && (
                <div>
                    <h2>Code Received by Server:</h2>
                    <pre>{responseCode}</pre>
                </div>
            )}

        </div>
    );
};

export default App;
