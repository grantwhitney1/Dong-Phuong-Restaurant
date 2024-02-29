import {defineConfig, loadEnv} from "vite";

export default defineConfig(({ mode }) => {
  const env = loadEnv(mode, process.cwd(), '');
  return {
    define: {
      __APP_ENV__: JSON.stringify(env.APP_ENV),
      VITE_API_BASE_URL: JSON.stringify(JSON.stringify(env.APP_ENV === 'development' ? 'https://localhost:7217/' : 'https://dong-phuong.azurewebsites.net')),
    },
  }
});
