using SoraApp.Entities;
using SoraApp.Forms.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoraApp.Forms.UserControls;

public partial class FeaturedArtItem : UserControl
{
    private Artwork artwork;

    public FeaturedArtItem(Artwork artwork)
    {
        this.artwork = artwork;
        InitializeComponent();
    }

    private void FeaturedArtItem_Load(object sender, EventArgs e)
    {
        TitleLbl.Text = artwork.Title;
        AuthorLbl.Text = artwork.User.FirstName + " " + artwork.User.LastName;
        GenreLbl.Text = artwork.GetType() == typeof(Audio) ? "Audio" : ((Book)artwork).Genres.First().Name;
    }

    private void CoverPb_Click(object sender, EventArgs e)
    {
        PDFViewModal pdfViewModal = new PDFViewModal();
        pdfViewModal.Show();
    }
}
