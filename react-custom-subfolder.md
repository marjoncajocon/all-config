# example: localhost/myapp/,, must configure the react-router-config.ts and vite.config.ts

#react-router-config.ts
import type { Config } from "@react-router/dev/config";
export default {
  // Config options...
  // Server-side render by default, to enable SPA mode set this to `false`
   basename: "/myapp", // specify here
  ssr: false
} satisfies Config;


# vite.config.ts
import { reactRouter } from "@react-router/dev/vite";
import tailwindcss from "@tailwindcss/vite";
import { defineConfig } from "vite";
import tsconfigPaths from "vite-tsconfig-paths";

export default defineConfig({
  plugins: [tailwindcss(), reactRouter(), tsconfigPaths()],
  base: "/myapp/" // specify this 
});
