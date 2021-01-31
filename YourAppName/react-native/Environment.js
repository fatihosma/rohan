const ENV = {
  dev: {
    apiUrl: 'http://localhost:44305',
    oAuthConfig: {
      issuer: 'http://localhost:44305',
      clientId: 'YourAppName_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access YourAppName',
    },
    localization: {
      defaultResourceName: 'YourAppName',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44305',
    oAuthConfig: {
      issuer: 'http://localhost:44305',
      clientId: 'YourAppName_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access YourAppName',
    },
    localization: {
      defaultResourceName: 'YourAppName',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
