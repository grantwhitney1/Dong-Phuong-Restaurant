import {createRoot} from 'react-dom/client';
import {BrowserRouter} from 'react-router-dom';
import App from './App';
import {createTheme, ThemeProvider} from '@mui/material';
import {red} from '@mui/material/colors'
import {QueryClient, QueryClientProvider} from "@tanstack/react-query";

const container = document.getElementById('root');
const root = createRoot(container!);

const queryClient = new QueryClient();

const theme = createTheme({
  palette: {
    primary: red,
  }
});

root.render(
  <QueryClientProvider client={queryClient}>
    <BrowserRouter>
      <ThemeProvider theme={theme}>
        <App/>
      </ThemeProvider>
    </BrowserRouter>
  </QueryClientProvider>
);