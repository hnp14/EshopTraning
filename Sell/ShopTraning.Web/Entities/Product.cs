using System.ComponentModel.DataAnnotations;

namespace ShopTraning.Web.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "عنوان محصول")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Title { get; set; }

        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string? Description { get; set; }

        [Display(Name = "توضیحات کوتاه")]
        [MaxLength(360, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string? ShortDescription { get; set; }
        [Display(Name = "قیمت")]

        public int Price { get; set; }

        [Display(Name = "نام تصویر")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string? Image { get; set; }
    }
}
