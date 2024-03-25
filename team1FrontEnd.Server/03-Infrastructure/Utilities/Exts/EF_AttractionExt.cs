using Azure;
using myapi._03_Infrastructure.DTOs;
using myapi.Models;
using myapi.Models.DTO;
using System.Linq;
using System.Net;

namespace myapi._03_Infrastructure.Utilities.Exts
{
    public static class EF_AttractionExt
    {
        public static AttractionDTO ToAttractionDTO(this Attraction a)
        {
            return new AttractionDTO
            {
                Id = a.Id,
                Name = a.Name,
                Address = a.Address,
                AttractionCategoryId = a.AttractionCategoryId,
                CityId = a.CityId,
                Description = a.Description,
                MainImage = a.MainImage,
                AttractionCategoryDTO = new AttractionCategoryDTO
                {
                    Id = a.AttractionCategory.Id,
                    Name = a.AttractionCategory.Name
                }
            };
        }
        public static AttractionContentDTO ToAttractionContentDTO(this Attraction c)
        {

            return new AttractionContentDTO
            {
                AttractionId = c.Id,
                AttractionName = c.Name,
                Address = c.Address,
                Latitude = c.Latitude,
                Longitude = c.Longitude,
                AttractionContentImageDTO = c.AttractionContentImages.Select(image => new AttractionContentImageDTO
                {
                    Image = image.Image,
                    ImageType = image.ImageType,
                    Description = image.Description,
                }).ToList(),
                AttractionContentContextDTO=c.AttractionContentContexts.Select(context=>new AttractionContentContextDTO
                {
                    SubTitle = context.SubTitle,
                    Tag=context.TagContent,
                    HightLight=context.Highlight,
                    ActivityDescription=context.ActivityDescription,
                    QA=context.Qa,
                }).ToList(),


            };
        }
    }
}
