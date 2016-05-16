﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TrinityCreator;

namespace TrinityCreator.CreatureTemplates
{
    class TemplateBase : TrinityCreature
    {
        public TemplateBase() : base() { }

        public CreatureCreatorPage Page
        {
            get
            {
                return (CreatureCreatorPage)App._MainWindow.CreatureCreatorTab.Content;
            }
        }

        public virtual void LoadTemplate()
        {
            throw new Exception("TemplateLoad() was not called.");
        }
        
        /// <summary>
        /// Set flags for the given BMSP
        /// </summary>
        /// <param name="bmsp"></param>
        /// <param name="flags"></param>
        public void SetBmspValues(BitmaskStackPanel bmsp, int[] flags)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Set Select combobox's index based on ID
        /// </summary>
        /// <param name="selectedValue">Value of selected item</param>
        /// <param name="creatureFamily"></param>
        public void SetComboboxValue(ComboBox cb, int id)
        {
            for (int i = 0; i < cb.Items.Count; i++)
            {
                if (((IKeyValue)cb.Items[i]).Id == id)
                {
                    cb.SelectedIndex = i;
                    break;
                }
            }
        }

        /// <summary>
        /// Set flags for the given DDC
        /// </summary>
        /// <param name="ddc"></param>
        /// <param name="flags"></param>
        public void SetDdcValues(DynamicDataControl ddc, string[] values, IKeyValue[] ikvKeys = null, string[] stringKeys = null)
        {
            throw new NotImplementedException();
        }
    }
}