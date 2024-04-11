import {defineConfig} from "vite";

export default defineConfig(({mode}) => {
  return {
    define: {
      'import.meta.env.VITE_API_BASE_URL': JSON.stringify(mode === 'development' ? 'https://localhost:7217/' : 'https://dong-phuong-api.azurewebsites.net/'),
    },
  }
});
