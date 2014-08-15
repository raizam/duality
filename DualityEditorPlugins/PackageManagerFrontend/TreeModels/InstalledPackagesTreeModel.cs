﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel;
using System.Threading;

using Aga.Controls.Tree;

using Duality.Editor.PackageManagement;

namespace Duality.Editor.Plugins.PackageManagerFrontend.TreeModels
{
	public class InstalledPackagesTreeModel : PackageRepositoryTreeModel
	{
		public InstalledPackagesTreeModel(PackageManager manager) : base(manager) {}

		protected override IEnumerable<object> EnumeratePackages()
		{
			return this.packageManager.LocalPackages;
		}
		protected override BaseItem CreatePackageItem(object package, BaseItem parentItem)
		{
			return new LocalPackageItem(package as LocalPackage, parentItem);
		}
	}
}