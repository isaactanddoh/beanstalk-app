# **Automated .NET Application Deployment to AWS Elastic Beanstalk**

## **Project Overview**
This project demonstrates the automated deployment of a .NET application to an AWS Elastic Beanstalk environment. The deployment process is fully automated using GitHub Actions, ensuring that every code change, especially modifications to the `program.cs` file, triggers an automatic deployment to the Beanstalk environment.

## **Key Features**
- **Automated Deployment**: Deployment is triggered automatically upon pushing code changes to the repository, with a focus on changes made to the `program.cs` file.
- **GitHub Actions Integration**: Utilizes GitHub Actions to streamline the Continuous Integration/Continuous Deployment (CI/CD) pipeline for the application.
- **AWS Elastic Beanstalk**: The application is hosted on AWS Elastic Beanstalk, providing a scalable and managed environment for .NET applications.

## **Directory Structure**
- **`/.github/workflows/`**:  
  Contains the GitHub Actions workflow files that automate the deployment process. The workflows are configured to trigger on specific events, such as code pushes.

- **`/app/`**:  
  Houses the source code of the .NET application, including the `program.cs` file which is a key trigger for the deployment workflow.

## **Continuous Deployment Process**
### **Triggering Deployment**
The deployment process is triggered automatically when a code change is pushed to the repository. Specifically, the GitHub Actions workflow is configured to listen for changes to the `program.cs` file. Once changes are detected, the workflow initiates the following steps:
1. **Build**: The .NET application is built and packaged.
2. **Deploy**: The application is deployed to the AWS Elastic Beanstalk environment.

### **Monitoring and Logs**
You can monitor the deployment process and review logs directly from the GitHub Actions tab in your repository. This provides real-time feedback on the status of your deployment.

## **Setup Instructions**

### **Prerequisites**
- **AWS Account**: Ensure you have an AWS account with the necessary permissions to deploy applications to Elastic Beanstalk.
- **GitHub Repository**: This project is hosted in a GitHub repository where GitHub Actions can be configured.

### **Clone the Repository**
```bash
git clone https://github.com/isaactanddoh/beanstalk-app.git
cd beanstalk-app
```

### **Workflow Configuration**
The deployment workflow is already set up in the `.github/workflows/` directory. To customize the workflow or add additional triggers, modify the YAML files within this directory.

## **Usage**

### **Pushing Code Changes**
When changes are made to the `program.cs` file (or any other part of the application), simply push your changes to the repository:
```bash
git add .
git commit -m "Updated program.cs"
git push origin main
```
This will automatically trigger the deployment process via GitHub Actions.

## **Contributions**
Contributions to enhance the project or improve the deployment pipeline are welcome! Please fork the repository, create a new branch, and submit a pull request.

## **Contact**
For any issues, questions, or suggestions, feel free to open an [issue](https://github.com/isaactanddoh/beanstalk-app/issues) on GitHub.
