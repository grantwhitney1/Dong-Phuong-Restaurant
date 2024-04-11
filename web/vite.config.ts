import {defineConfig} from "vite";
import "vite-plugin-mkcert";
import mkcert from "vite-plugin-mkcert";

export default defineConfig(({mode}) => {
  return {
    server: {
      port: 3000,
    },
    plugins: [mkcert()],
    define: {
      'import.meta.env.VITE_API_BASE_URL': JSON.stringify(mode === 'development' ? 'https://localhost:7217/' : 'https://dong-phuong-api.azurewebsites.net/'), // TODO: Invert Boolean Operation
    },
  };
});