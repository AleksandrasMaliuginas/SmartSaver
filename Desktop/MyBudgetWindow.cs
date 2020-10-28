﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using SmartSaver.Data;
using SmartSaver.Models;

namespace SmartSaver.Desktop
{
    public partial class MyBudgetWindow : Form
    {
        private readonly Database db = new Database();
        private List<Category> CategoryList;

        private int selectedId;

        public MyBudgetWindow()
        {
            InitializeComponent();
        }

        private void MyBudgetWindow_Load(object sender, EventArgs e)
        {
            UpdateCategoriesList();
        }

        public void UpdateCategoriesList()
        {
            CategoryList = (List<Category>)db.GetCategories();
            PopulateCategoryListView();
        }

        private void PopulateCategoryListView()
        {
            PopulateCategoryListView(CategoryList);
        }

        private void PopulateCategoryListView(IEnumerable<Category> CategoryList)
        {
            //this.budgetAndCategoriesView.Rows.Add("1", "Shopping", "30", "30", "0");
            foreach (var category in CategoryList)
            {
                budgetAndCategoriesView.Rows.Add(category.Id, category.Title, " ", " ");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var title = budgetAndCategoriesView.Rows[budgetAndCategoriesView.RowCount - 2].Cells[1].Value.ToString();
            var db = new Database();

            var newCategory = new Category {Title = title};

            try
            {
                db.AddCategory(newCategory);
                MessageBox.Show("New category added successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Category dublicate");
                budgetAndCategoriesView.Rows[budgetAndCategoriesView.RowCount - 2].Cells[0].Value = null;
                budgetAndCategoriesView.Rows[budgetAndCategoriesView.RowCount - 2].Cells[1].Value = null;
                budgetAndCategoriesView.Rows[budgetAndCategoriesView.RowCount - 2].Cells[2].Value = null;
                budgetAndCategoriesView.Rows[budgetAndCategoriesView.RowCount - 2].Cells[3].Value = null;
                budgetAndCategoriesView.Rows[budgetAndCategoriesView.RowCount - 2].Cells[4].Value = null;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedTitle = budgetAndCategoriesView.Rows[selectedId].Cells[1].Value.ToString();
            var db = new Database();

            db.RemoveCategory(selectedTitle);
            Debug.WriteLine(selectedId);
            budgetAndCategoriesView.Rows.RemoveAt(selectedId);
            MessageBox.Show("Row deleted");
        }

        private void budgetAndCategoriesView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = e.RowIndex;
        }
    }
}