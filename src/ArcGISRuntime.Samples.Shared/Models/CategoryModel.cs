﻿// Copyright 2016 Esri.
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License.
// You may obtain a copy of the License at: http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an 
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific 
// language governing permissions and limitations under the License.

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ArcGISRuntime.Samples.Models
{
    /// <summary>
    /// CategoryModel defines a main level categories. These are mainly used to categorize
    /// groups of samples under specific high level topics like "Map" or "Routing & Navigation".
    /// Samples are always located under sub-categories
    /// </summary>
    [DataContract(Name ="Category")]
    public class CategoryModel
    {
        /// <summary>
        /// Gets or sets the human readable name of the category. 
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the category.
        /// </summary>
        [DataMember]
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or sets the list of sub-categories that belongs into this category.
        /// </summary>
        [DataMember]
        public List<SubCategoryModel> SubCategories { get; set; }
    }
}
