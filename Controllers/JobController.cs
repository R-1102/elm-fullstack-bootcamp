using Microsoft.AspNetCore.Mvc;
using W2D4.Models;
using System;
using System.Collections.Generic;
using System.Linq;

public class JobController : Controller
{
    private static List<JobListing> jobs = new List<JobListing>
    {
        new JobListing { Id = 1, Title = "Software Engineer", CompanyName = "Microsoft", Location = "Riyadh", JobType = JobType.FullTime, PostedDate = DateTime.Now.AddDays(-2) },
        new JobListing { Id = 2, Title = "Data Scientist", CompanyName = "Google", Location = "Jeddah", JobType = JobType.Remote, PostedDate = DateTime.Now.AddDays(-5) },
        new JobListing { Id = 3, Title = "DevOps Engineer", CompanyName = "Amazon", Location = "Dammam", JobType = JobType.Contract, PostedDate = DateTime.Now.AddDays(-1) },
        new JobListing { Id = 4, Title = "Frontend Developer", CompanyName = "Facebook", Location = "Medina", JobType = JobType.PartTime, PostedDate = DateTime.Now.AddDays(-3) },
        new JobListing { Id = 5, Title = "Cybersecurity Analyst", CompanyName = "IBM", Location = "Tabuk", JobType = JobType.FullTime, PostedDate = DateTime.Now.AddDays(-7) }
    };

    public IActionResult Index(string search, JobType? filter, string sort)
    {
        var filteredJobs = jobs.AsQueryable();

        if (!string.IsNullOrEmpty(search))
        {
            filteredJobs = filteredJobs.Where(j => j.Title.Contains(search, StringComparison.OrdinalIgnoreCase) || j.CompanyName.Contains(search, StringComparison.OrdinalIgnoreCase));
        }

        if (filter.HasValue)
        {
            filteredJobs = filteredJobs.Where(j => j.JobType == filter);
        }

        return View(filteredJobs.ToList());
    }

    public IActionResult Details(int id)
    {
        var job = jobs.FirstOrDefault(j => j.Id == id);
        if (job == null) return NotFound();
        return View(job);
    }
}
