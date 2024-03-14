import {createRoot} from 'react-dom/client';
import {BrowserRouter} from 'react-router-dom';
import App from './App';
import {createTheme, ThemeProvider} from '@mui/material';
import {blue} from '@mui/material/colors'

const container = document.getElementById('root');
const root = createRoot(container!);

const theme = createTheme({
  palette: {
    primary: blue
  }
});

root.render(
  <BrowserRouter>
    <ThemeProvider theme={theme}>
      <App/>
    </ThemeProvider>
  </BrowserRouter>
);