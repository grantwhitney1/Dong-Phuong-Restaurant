import {defineConfig, loadEnv} from "vite";

export default defineConfig(({ mode }) => {
  // Load env file based on `mode` in the current working directory.
  // Set the third parameter to '' to load all env regardless of the `VITE_` prefix.
  const env = loadEnv(mode, process.cwd(), '')
  return {
    // vite config
    define: {
      __APP_ENV__: JSON.stringify(env.APP_ENV),
      VITE_API_BASE_URL: env.APP_ENV === 'development' ? 'https://localhost:7217/' : 'https://dong-phuong.azurewebsites.net',
    },
  }
})