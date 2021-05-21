import { useEffect, useState } from "react";

function App() {
  const [weather, setWeather] = useState({});

     
  useEffect(() => {
    fetch('weatherforecast').then(response => {
      if (!response.ok) {
        throw new Error("Network response was not ok");
      }
      return response.json();
    }).then(weatherData => {
      console.log(weatherData);
      setWeather(weatherData);
    })
      .catch(error => {
        console.error('There has been a problem with your fetch operation:', error);
      })
  }, [])


  return (
      <div className="App">
          <div>Weather</div>
      <div>{weather.tempurature}</div>
      <div>{weather.created_At}</div>
    </div>
  );
}

export default App;
