import { defineConfig } from "vite";

export default defineConfig(({ mode }) => {
  return {
    server: {
      port: 3000,
    },
    define: {
      'import.meta.env.VITE_API_BASE_URL': JSON.stringify(mode === 'development' ? 'https://localhost:7217/' : 'https://dong-phuong.azurewebsites.net/'),
    },
  };
});
